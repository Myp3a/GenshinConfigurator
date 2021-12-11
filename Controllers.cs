using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GenshinConfigurator
{
    internal class KeyboardKeybind
    {
        public int action_id;
        public int axis_contribution;
        public int elementIdentifierId;
        public int keyboard_keycode;
        public bool shift = false, ctrl = false, alt = false;
        public KeyboardKeybind(XElement xmldata)
        {
            LoadFromXml(xmldata);
        }

        public void LoadFromXml(XElement xmldata)
        {
            XNamespace ns = "http://guavaman.com/rewired";
            action_id = Convert.ToInt32(xmldata.Element(ns + "actionId").Value);
            axis_contribution = Convert.ToInt32(xmldata.Element(ns + "axisContribution").Value);
            elementIdentifierId = Convert.ToInt32(xmldata.Element(ns + "elementIdentifierId").Value);
            keyboard_keycode = Convert.ToInt32(xmldata.Element(ns + "keyboardKeyCode").Value);
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
            /*foreach (XmlNode bindingValue in xmldata.ChildNodes)
            {
                if (bindingValue.Name == "keyboardKeyCode")
                {
                    keyboard_keycode = Convert.ToInt32(bindingValue.InnerText);
                }
                else if (bindingValue.Name == "actionId")
                {
                    action_id = Convert.ToInt32(bindingValue.InnerText);
                }
                else if ((bindingValue.Name == "modifierKey1") || (bindingValue.Name == "modifierKey2") || (bindingValue.Name == "modifierKey3"))
                {
                    int modval = Convert.ToInt32(bindingValue.InnerText);
                    switch (modval)
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
                        default:
                            break;
                    }
                }
            }*/
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
                    if (mod2 != 0) { mod3 = 3; } else {  mod2 = 3; } 
                } else
                {
                    mod1 = 3;
                }
            }
            XElement xml = new XElement("ActionElementMap",
                new XElement("actionCategoryId", 0),
                new XElement("actionId", action_id),
                new XElement("elementType", 1),
                new XElement("elementIdentifierId", elementIdentifierId),
                new XElement("axisRange", 0),
                new XElement("invert", false),
                new XElement("axisContribution", axis_contribution),
                new XElement("keyboardKeyCode", keyboard_keycode),
                new XElement("modifierKey1", mod1),
                new XElement("modifierKey2", mod2),
                new XElement("modifierKey3", mod3),
                new XElement("enabled", true));
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

        public abstract void LoadFromString(string xmlstring);
        public abstract string DumpToString(bool format);

        public abstract XElement BuildObject();

    }

    internal class KeyboardController : Controller
    {
        List<KeyboardKeybind> keybinds = new List<KeyboardKeybind>();
        public KeyboardController()
        {

        }

        public override void LoadFromString(string xmlstring)
        {
            XElement xml = XElement.Parse(xmlstring);
            sourceMapId = (int)(from el in xml.Descendants("sourceMapId") select el).First();
            categoryId = (int)(from el in xml.Descendants("categoryId") select el).First();
            layoutId = (int)(from el in xml.Descendants("layoutId") select el).First();
            name = (string)(from el in xml.Descendants("name") select el).First();
            hardwareGuid = (string)(from el in xml.Descendants("hardwareGuid") select el).First();
            enabled = (bool)(from el in xml.Descendants("enabled") select el).First();
            foreach (XElement bind in (from el in xml.Descendants("buttonMaps") select el).First().Elements())
            {
                keybinds.Add(new KeyboardKeybind(bind));
            };
        }

        public override XElement BuildObject()
        {
            XElement buttonMaps = new XElement("buttonMaps");
            foreach (KeyboardKeybind bind in keybinds)
            {
                buttonMaps.Add(bind.DumpToXml());
            }
            XElement xml = new XElement("KeyboardMap",
                new XAttribute("dataVersion", 2),
                new XAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                new XAttribute("xsi:schemaLocation", "http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd"),
                new XAttribute("xmlns", "http://guavaman.com/rewired"),
                new XElement("sourceMapId", sourceMapId),
                new XElement("categoryId", categoryId),
                new XElement("layoutId", layoutId),
                new XElement("name", name),
                new XElement("hardwareGuid", hardwareGuid),
                new XElement("enabled", enabled),
                new XElement("buttonMaps", buttonMaps));
            return xml;
        }
        public override string DumpToString(bool format = false)
        {
            if (format)
            {
                return BuildObject().ToString();
            } else
            {
                return BuildObject().ToString(SaveOptions.DisableFormatting);
            }
        }
    }
    internal class Controllers
    {
        public Controllers()
        {

        }
        /*private string[] GetControllerBindings()
        {
            return ;
        }*/
    }
}
