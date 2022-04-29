using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GenshinConfigurator
{
    internal class Keybind
    {
        public int actionId;
        // 1 for action 54, 0 otherwise - let's assume that it's 0 most of the time
        public int axisContribution;
        public int elementIdentifierId;
        // Becomes 0, 1 and 2 for different keys - only 0's are known actions. Assuming 0 as right value for now
        public int axisRange;
        public bool invert;
        public int keyboardKeyCode;

        public Keybind()
        {

        }
    }

    internal class GamepadAxis : Keybind
    {

        // 1 for action 54, 0 otherwise - let's assume that it's 0 most of the time
        // public int axisContribution;

        // Becomes 0, 1 and 2 for different keys - only 0's are known actions. Assuming 0 as right value for now
        // public int axisRange;

        public GamepadAxis()
        {
            this.axisContribution = 0;
            this.axisRange = 0;
            this.invert = false;
        }

        public GamepadAxis(XElement xmldata)
        {
            LoadFromXml(xmldata);
        }

        public GamepadAxis(GamepadKeybind bind)
        {
            // Convert from button to axis, for LT / RT
            this.axisContribution = 0;
            this.elementIdentifierId = bind.elementIdentifierId;
            this.actionId = bind.actionId;
            this.axisRange = 0;
            this.invert = bind.invert;
        }

        public void LoadFromXml(XElement xmldata)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            actionId = Convert.ToInt32(xmldata.Element(ns + "actionId").Value);
            axisContribution = Convert.ToInt32(xmldata.Element(ns + "axisContribution").Value);
            elementIdentifierId = Convert.ToInt32(xmldata.Element(ns + "elementIdentifierId").Value);
            axisRange = Convert.ToInt32(xmldata.Element(ns + "axisRange").Value);
            invert = Convert.ToBoolean(xmldata.Element(ns + "invert").Value);
        }

        public XElement DumpToXml()
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = new XElement(ns + "ActionElementMap",
                new XElement(ns + "actionCategoryId", 0),
                new XElement(ns + "actionId", actionId),
                new XElement(ns + "elementType", 0),
                new XElement(ns + "elementIdentifierId", elementIdentifierId),
                new XElement(ns + "axisRange", axisRange),
                new XElement(ns + "invert", invert),
                new XElement(ns + "axisContribution", axisContribution),
                new XElement(ns + "keyboardKeyCode", 0),
                new XElement(ns + "modifierKey1", 0),
                new XElement(ns + "modifierKey2", 0),
                new XElement(ns + "modifierKey3", 0),
                new XElement(ns + "enabled", true));
            return xml;
        }
    }

    internal class GamepadKeybind : Keybind
    {
        public GamepadKeybind()
        {
            this.axisContribution = 0;
            this.axisRange = 0;
            this.invert = false;
        }

        public GamepadKeybind(XElement xmldata)
        {
            LoadFromXml(xmldata);
        }

        public GamepadKeybind(GamepadAxis axis)
        {
            // Convert from axis to button, for LT / RT
            this.axisContribution = 0;
            this.elementIdentifierId = axis.elementIdentifierId;
            this.actionId = axis.actionId;
            this.axisRange = 0;
            this.invert = axis.invert;
        }

        public void LoadFromXml(XElement xmldata)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            actionId = Convert.ToInt32(xmldata.Element(ns + "actionId").Value);
            axisContribution = Convert.ToInt32(xmldata.Element(ns + "axisContribution").Value);
            elementIdentifierId = Convert.ToInt32(xmldata.Element(ns + "elementIdentifierId").Value);
            axisRange = Convert.ToInt32(xmldata.Element(ns + "axisRange").Value);
            invert = Convert.ToBoolean(xmldata.Element(ns + "invert").Value);
        }

        public XElement DumpToXml()
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = new XElement(ns + "ActionElementMap",
                new XElement(ns + "actionCategoryId", 0),
                new XElement(ns + "actionId", actionId),
                new XElement(ns + "elementType", 1),
                new XElement(ns + "elementIdentifierId", elementIdentifierId),
                new XElement(ns + "axisRange", axisRange),
                new XElement(ns + "invert", invert),
                new XElement(ns + "axisContribution", axisContribution),
                new XElement(ns + "keyboardKeyCode", 0),
                new XElement(ns + "modifierKey1", 0),
                new XElement(ns + "modifierKey2", 0),
                new XElement(ns + "modifierKey3", 0),
                new XElement(ns + "enabled", true));
            return xml;
        }
    }

    internal class KeyboardKeybind : Keybind
    {
        public bool shift = false, ctrl = false, alt = false;

        public KeyboardKeybind()
        {
            this.axisContribution = 0;
            this.keyboardKeyCode = 0;
        }

        public KeyboardKeybind(XElement xmldata)
        {
            LoadFromXml(xmldata);
        }

        public void LoadFromXml(XElement xmldata)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            actionId = Convert.ToInt32(xmldata.Element(ns + "actionId").Value);
            axisContribution = Convert.ToInt32(xmldata.Element(ns + "axisContribution").Value);
            elementIdentifierId = Convert.ToInt32(xmldata.Element(ns + "elementIdentifierId").Value);
            keyboardKeyCode = Convert.ToInt32(xmldata.Element(ns + "keyboardKeyCode").Value);
            int mod1 = Convert.ToInt32(xmldata.Element(ns + "modifierKey1").Value);
            int mod2 = Convert.ToInt32(xmldata.Element(ns + "modifierKey2").Value);
            int mod3 = Convert.ToInt32(xmldata.Element(ns + "modifierKey3").Value);
            foreach (int mod in new List<int> { mod1, mod2, mod3 })
            {
                switch (mod)
                {
                    case 1:
                        ctrl = true;
                        break;
                    case 2:
                        alt = true;
                        break;
                    case 3:
                        shift = true;
                        break;
                }
            }
        }

        public XElement DumpToXml()
        {
            int mod1 = 0, mod2 = 0, mod3 = 0;
            if (ctrl)
            {
                mod1 = 1;
            }
            if (alt)
            {
                if (mod1 != 0) { mod2 = 2; } else { mod1 = 2; }
            }
            if (shift)
            {
                if (mod1 != 0)
                {
                    if (mod2 != 0) { mod3 = 3; } else { mod2 = 3; }
                }
                else
                {
                    mod1 = 3;
                }
            }
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = new XElement(ns + "ActionElementMap",
                new XElement(ns + "actionCategoryId", 0),
                new XElement(ns + "actionId", actionId),
                new XElement(ns + "elementType", 1),
                new XElement(ns + "elementIdentifierId", elementIdentifierId),
                new XElement(ns + "axisRange", 0),
                new XElement(ns + "invert", false),
                new XElement(ns + "axisContribution", axisContribution),
                new XElement(ns + "keyboardKeyCode", keyboardKeyCode),
                new XElement(ns + "modifierKey1", mod1),
                new XElement(ns + "modifierKey2", mod2),
                new XElement(ns + "modifierKey3", mod3),
                new XElement(ns + "enabled", true));
            return xml;
        }
    }

    internal abstract class Controller
    {
        public int sourceMapId;
        public int categoryId;
        public int layoutId;
        public string name;
        public string hardwareGuid;
        public bool enabled;
        public abstract List<Keybind> keybinds { get; set; }
        public abstract List<Keybind> axes { get; set; }

        public abstract void LoadFromString(string xmlstring);
        public abstract void AddBind(int actionId);
        public abstract void EditBind(Keybind bind, int key);
        public abstract XDocument BuildObject();

        public void DeleteBind(Keybind bind)
        {
            if (axes.Contains(bind))
            {
                axes.Remove(bind);
            }
            if (keybinds.Contains(bind))
            {
                keybinds.Remove(bind);
            }
        }

        public string DumpToString(bool format)
        {
            if (format)
            {
                return BuildObject().ToString();
            }
            else
            {
                string xml_string;
                using (var strw = new StringWriter())
                {
                    BuildObject().Save(strw, SaveOptions.DisableFormatting);
                    xml_string = strw.ToString();
                    return xml_string;
                }
            }
        }
    }

    internal class MouseController : Controller
    {
        public override List<Keybind> keybinds { get; set; }
        public override List<Keybind> axes { get; set; }

        public MouseController()
        {
            keybinds = new List<Keybind>();
            axes = new List<Keybind>();
        }

        public override void AddBind(int actionId)
        {
            // 0 - Horizontal mouse movement
            // 3 - LMB
            List<int> axis_actions = new List<int> { 0, 1, 2 }; // Movement and wheel
            if (axis_actions.Contains(actionId))
            {
                GamepadAxis newbind = new GamepadAxis();
                newbind.elementIdentifierId = 0;
                newbind.actionId = actionId;
                axes.Add(newbind);
            }
            else
            {
                GamepadKeybind newbind = new GamepadKeybind();
                newbind.elementIdentifierId = 3;
                newbind.actionId = actionId;
                keybinds.Add(newbind);
            }
        }

        public override void EditBind(Keybind bind, int key)
        {
            bind.elementIdentifierId = key;
        }

        public override XDocument BuildObject()
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement buttonMaps = new XElement(ns + "buttonMaps");
            XElement axisMaps = new XElement(ns + "axisMaps");

            foreach (GamepadKeybind bind in keybinds)
            {
                buttonMaps.Add(bind.DumpToXml());
            }

            foreach (GamepadAxis bind in axes)
            {
                axisMaps.Add(bind.DumpToXml());
            }

            XNamespace xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-16", null),
                new XElement(ns + "MouseMap",
                    new XAttribute("dataVersion", 2),
                    new XAttribute(XNamespace.Xmlns + "xsi", xsi),
                    new XAttribute(xsi + "schemaLocation", "http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/MouseMap.xsd"),
                    new XElement(ns + "sourceMapId", sourceMapId),
                    new XElement(ns + "categoryId", categoryId),
                    new XElement(ns + "layoutId", layoutId),
                    new XElement(ns + "name", name),
                    new XElement(ns + "hardwareGuid", hardwareGuid),
                    new XElement(ns + "enabled", enabled),
                    buttonMaps,
                    axisMaps
                )
            );

            return xml;
        }

        public override void LoadFromString(string xmlstring)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = XElement.Parse(xmlstring);
            sourceMapId = (int)(from el in xml.Descendants() where el.Name == ns + "sourceMapId" select el).First();
            categoryId = (int)(from el in xml.Descendants() where el.Name == ns + "categoryId" select el).First();
            layoutId = (int)(from el in xml.Descendants() where el.Name == ns + "layoutId" select el).First();
            name = (string)(from el in xml.Descendants() where el.Name == ns + "name" select el).First();
            hardwareGuid = (string)(from el in xml.Descendants() where el.Name == ns + "hardwareGuid" select el).First();
            enabled = (bool)(from el in xml.Descendants() where el.Name == ns + "enabled" select el).First();
            IEnumerable<XElement> keybindings =
                from el in xml.Descendants()
                where el.Name == ns + "ActionElementMap"
                select el;
            foreach (XElement bindingNode in keybindings)
            {
                if (bindingNode.Element(ns + "elementType").Value == "1")
                {
                    GamepadKeybind bind = new GamepadKeybind(bindingNode);
                    keybinds.Add(bind);
                }
                else if (bindingNode.Element(ns + "elementType").Value == "0")
                {
                    GamepadAxis bind = new GamepadAxis(bindingNode);
                    axes.Add(bind);
                }
            }
        }
    }

    internal class XBoxController : Controller
    {
        public override List<Keybind> keybinds { get; set; }
        public override List<Keybind> axes { get; set; }

        public XBoxController()
        {
            keybinds = new List<Keybind>();
            axes = new List<Keybind>();
        }

        public override void AddBind(int actionId)
        {
            // 22 - Guide button. Unused in game, so here it's like "not defined".
            List<int> axis_actions = new List<int> { 0, 1 }; // Forward and side movement. Axis keybinds are different, so let's leave it like that for now
            if (axis_actions.Contains(actionId))
            {
                GamepadAxis newbind = new GamepadAxis();
                newbind.elementIdentifierId = 22;
                newbind.actionId = actionId;
                axes.Add(newbind);
            }
            else
            {
                GamepadKeybind newbind = new GamepadKeybind();
                newbind.elementIdentifierId = 22;
                newbind.actionId = actionId;
                keybinds.Add(newbind);
            }
        }

        public override void EditBind(Keybind bind, int key)
        {
            // LT and RT stands out from other keys.
            // They are mapped as axes, but behave like buttons.
            // For now, let's restrict them from axes mappings.
            //
            // Still, when changing button mappings, we should convert them to appropriate class.
            // It's Axis when LT/RT is used, and Button, when not.

            if (key < 4) // Sticks axes
            {
                bind.elementIdentifierId = key;
            }
            else if (key < 6) // LT, RT
            {
                if (bind is GamepadKeybind) // Converting to LT/RT
                {
                    DeleteBind(bind);
                    bind = new GamepadAxis((GamepadKeybind)bind);
                    axes.Add(bind);
                }
                bind.elementIdentifierId = key;
            } 
            else // Ordinary buttons
            {
                if (bind is GamepadAxis) // Converting from LT/RT
                {
                    DeleteBind(bind);
                    bind = new GamepadKeybind((GamepadAxis)bind);
                    keybinds.Add(bind);
                }
                bind.elementIdentifierId = key;
            }
        }

        public override void LoadFromString(string xmlstring)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = XElement.Parse(xmlstring);
            sourceMapId = (int)(from el in xml.Descendants() where el.Name == ns + "sourceMapId" select el).First();
            categoryId = (int)(from el in xml.Descendants() where el.Name == ns + "categoryId" select el).First();
            layoutId = (int)(from el in xml.Descendants() where el.Name == ns + "layoutId" select el).First();
            name = (string)(from el in xml.Descendants() where el.Name == ns + "name" select el).First();
            hardwareGuid = (string)(from el in xml.Descendants() where el.Name == ns + "hardwareGuid" select el).First();
            enabled = (bool)(from el in xml.Descendants() where el.Name == ns + "enabled" select el).First();
            IEnumerable<XElement> keybindings =
                from el in xml.Descendants()
                where el.Name == ns + "ActionElementMap"
                select el;
            foreach (XElement bindingNode in keybindings)
            {
                if (bindingNode.Element(ns + "elementType").Value == "1")
                {
                    GamepadKeybind bind = new GamepadKeybind(bindingNode);
                    keybinds.Add(bind);
                } else if (bindingNode.Element(ns + "elementType").Value == "0")
                {
                    GamepadAxis bind = new GamepadAxis(bindingNode);
                    axes.Add(bind);
                }
            }
        }

        public override XDocument BuildObject()
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement buttonMaps = new XElement(ns + "buttonMaps");
            XElement axisMaps = new XElement(ns + "axisMaps");

            foreach (GamepadKeybind bind in keybinds)
            {
                buttonMaps.Add(bind.DumpToXml());
            }

            foreach (GamepadAxis bind in axes)
            {
                axisMaps.Add(bind.DumpToXml());
            }

            XNamespace xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-16", null),
                new XElement(ns + "JoystickMap",
                    new XAttribute("dataVersion", 2),
                    new XAttribute(XNamespace.Xmlns + "xsi", xsi),
                    new XAttribute(xsi + "schemaLocation", "http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd"),
                    new XElement(ns + "sourceMapId", sourceMapId),
                    new XElement(ns + "categoryId", categoryId),
                    new XElement(ns + "layoutId", layoutId),
                    new XElement(ns + "name", name),
                    new XElement(ns + "hardwareGuid", hardwareGuid),
                    new XElement(ns + "enabled", enabled),
                    buttonMaps,
                    axisMaps
                )
            );

            return xml;
        }
    }
    internal class KeyboardController : Controller
    {
        public override List<Keybind> keybinds { get; set; }
        public override List<Keybind> axes { get; set; }
        public KeyboardController()
        {
            keybinds = new List<Keybind>();
            // Empty here
            axes = new List<Keybind>();
        }

        public override void AddBind(int actionId)
        {
            KeyboardKeybind newbind = new KeyboardKeybind();
            newbind.elementIdentifierId = 0;
            newbind.actionId = actionId;
            keybinds.Add(newbind);
        }

        public override void EditBind(Keybind bind, int key)
        {
            bind.elementIdentifierId = key;
        }

        public override void LoadFromString(string xmlstring)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement xml = XElement.Parse(xmlstring);
            sourceMapId = (int)(from el in xml.Descendants() where el.Name == ns + "sourceMapId" select el).First();
            categoryId = (int)(from el in xml.Descendants() where el.Name == ns + "categoryId" select el).First();
            layoutId = (int)(from el in xml.Descendants() where el.Name == ns + "layoutId" select el).First();
            name = (string)(from el in xml.Descendants() where el.Name == ns + "name" select el).First();
            hardwareGuid = (string)(from el in xml.Descendants() where el.Name == ns + "hardwareGuid" select el).First();
            enabled = (bool)(from el in xml.Descendants() where el.Name == ns + "enabled" select el).First();
            IEnumerable<XElement> keybindings =
                from el in xml.Descendants()
                where el.Name == ns + "ActionElementMap"
                select el;
            foreach (XElement bindingNode in keybindings)
            {
                KeyboardKeybind bind = new KeyboardKeybind(bindingNode);
                keybinds.Add(bind);
            }
        }

        public override XDocument BuildObject()
        {
            XNamespace ns = "http://guavaman.com/rewired";
            XElement buttonMaps = new XElement(ns + "buttonMaps");
            foreach (KeyboardKeybind bind in keybinds)
            {
                buttonMaps.Add(bind.DumpToXml());
            }

            XNamespace xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-16", null),
                new XElement(ns + "KeyboardMap",
                    new XAttribute("dataVersion", 2),
                    new XAttribute(XNamespace.Xmlns + "xsi", xsi),
                    //new XAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                    new XAttribute(xsi + "schemaLocation", "http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd"),
                    //new XAttribute("xsi:schemaLocation", "http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd"),
                    //new XAttribute("xmlns", "http://guavaman.com/rewired"),
                    new XElement(ns + "sourceMapId", sourceMapId),
                    new XElement(ns + "categoryId", categoryId),
                    new XElement(ns + "layoutId", layoutId),
                    new XElement(ns + "name", name),
                    new XElement(ns + "hardwareGuid", hardwareGuid),
                    new XElement(ns + "enabled", enabled),
                    buttonMaps
                )
            );
            /*foreach (var node in xml.Descendants())
            {
                if (!(node.Name.NamespaceName == "http://guavaman.com/rewired")) node.Name = node.Name.LocalName;
            }*/

            return xml;
        }
    }
    internal class Controllers
    {
        List<Controller> controllers;

        public Controllers()
        {
            controllers = new List<Controller>();
        }
        
        public void Add(Controller cntrl)
        {
            controllers.Add(cntrl);
        }

        public void Remove(Controller cntrl)
        {
            controllers.Remove(cntrl);
        }

        public IEnumerable<Controller> List()
        {
            foreach (Controller cntrl in controllers)
            {
                yield return cntrl;
            }
        }

        public Controller Controller_By_Bind(Keybind bind)
        {
            //Search for the controller that the bind is assigned to
            foreach (Controller ctrl in controllers)
            {
                if (ctrl.axes.Contains(bind) || ctrl.keybinds.Contains(bind))
                {
                    return ctrl;
                }
            }
            return null;
        }

        public static int GetActionByName(string name)
        {
            int actionId;
            try
            {
                actionId = Convert.ToInt32(name);
            }
            catch
            {
                actionId = Keycodes.actions.Where(c => c.Value == name).First().Key;
            }
            return actionId;
        }
    }
}
