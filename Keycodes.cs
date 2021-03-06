using System.Collections.Generic;
using System.Windows.Forms;

namespace GenshinConfigurator
{
    internal class Keycodes
    {
        public static List<string> gamepad_axes = new List<string>
        {
            "Left Stick X",
            "Left Stick Y",
            "Right Stick X",
            "Right Stick Y",
            "LT",
            "RT"
        };

        public static List<string> xbox_gamepad_keys = new List<string>
        {
            "LT",
            "RT",
            "A",
            "B",
            "X",
            "Y",
            "LB",
            "RB",
            "Back",
            "Start",
            "Left Stick Button",
            "Right Stick Button",
            "D-Pad Up",
            "D-Pad Right",
            "D-Pad Down",
            "D-Pad Left",
            "Left Stick",
            "Right Stick",
            "Guide"
        };

        public static List<string> dualsense_gamepad_keys = new List<string>
        {
            "LT",
            "RT",
            "Cross",
            "Circle",
            "Square",
            "Triangle",
            "L1",
            "R1",
            "Create",
            "Options",
            "PS Button",
            "Touchpad Button",
            "Left Stick Button",
            "Right Stick Button",
            "D-Pad Up",
            "D-Pad Right",
            "D-Pad Down",
            "D-Pad Left",
            "Left Stick",
            "Right Stick",
            "Mute"
        };

        public static List<string> mouse_axes = new List<string>
        {
            // 0 - 2
            "Mouse Horizontal",
            "Mouse Vertical",
            "Mouse Wheel"
        };

        public static List<string> mouse_keys = new List<string>
        {
            // 3 - 9
            "Left Mouse Button",
            "Right Mouse Button",
            "Middle Mouse Button",
            "Mouse 4",
            "Mouse 5",
            "Mouse 6",
            "Mouse 7"
        };

        public static Dictionary<int,string> actions = new Dictionary<int, string>
        {
            { 0, "Side Movement" },
            { 1, "Forward Movement"},
            { 2, "Map" },
            { 3, "Character List" },
            { 4, "Inventory" },
            { 5, "Menu (Gamepad)" },
            { 6, "Quest List" },
            { 7, "Char 1" },
            { 8, "Char 2" },
            { 9, "Char 3" },
            { 10, "Adventurer Handbook" },
            // 11 - 14 resets themselves, when game is opened
            { 15, "Jump" },
            { 16, "Attack" },
            { 17, "Elemental Skill" },
            { 18, "Quest Transport?" },
            { 19, "Item Info" },
            { 20, "Elemental Burst" },
            { 21, "Sprint" },
            { 22, "Use/Talk" },
            { 23, "Move Forward: Show?" },
            { 24, "Move Left: Show?" },
            { 25, "Move Right: Show?" },
            { 26, "Move Back: Show?" },
            { 27, "Aim Mode" },
            { 28, "Aim Button" },
            { 29, "Move?" },
            { 30, "Camera: Horizontal view" },
            { 31, "Camera: Vertical view" },
            { 32, "View?" },
            { 33, "Quick Wheel" },
            { 34, "Top Menu: Left" },
            { 35, "Top Menu: Right" },
            // 36 - 39 resets themselves
            { 40, "Menu Select" },
            { 41, "Auxiliary Action" },
            { 42, "Menu/Back" },
            { 43, "D-Pad Up" },
            { 44, "D-Pad Right" },
            { 45, "D-Pad Down" },
            { 46, "D-Pad Left" },
            { 47, "Menu: Up" },
            { 48, "Menu: Right" },
            { 49, "Menu: Down" },
            { 50, "Menu: Left" },
            { 51, "Less" },
            { 52, "More" },
            { 53, "Cancel Climb" },
            { 54, "Camera: View distance" },
            { 55, "Walk/Run" },
            { 56, "Show Cursor" },
            { 57, "Elemental Sight" },
            { 58, "Debug Menu" },
            { 59, "Right Stick Up?" },
            { 60, "Right Stick Right?" },
            { 61, "Right Stick Down?" },
            { 62, "Right Stick Left?" },
            { 63, "Secondary Action" },
            { 64, "Right Stick Vertical?" },
            { 65, "Co-Op" },
            { 66, "Char 4" },
            { 67, "Lock Item / Mark" },
            { 68, "Right Stick Horizontal?" },
            { 69, "Left Stick Horzontal?" },
            { 70, "Left Stick Vertical?" },
            { 71, "Menu Right?" },
            { 72, "Menu Down?" },
            { 73, "Wish" },
            { 75, "Chat" },
            { 76, "Notification Details" },
            { 77, "Environment Info" },
            { 78, "Char 5" },
            { 79, "Adventurer Handbook?" },
            { 80, "Navigation" },
            { 81, "Tutorial" },
            { 82, "Events" },
            { 83, "Battle Pass" },
            { 84, "Abandon Challenge" },
            { 85, "Abandon Challenge (Gamepad)" },
            { 86, "Photo: Hide UI" },
            { 87, "Gadget" },
            { 88, "Interaction (some modes)" },
            { 89, "Extra Up?" },
            { 90, "Extra Down?" },
            { 91, "Extra Left?" },
            { 92, "Extra Right?" },
            { 94, "Music: Left Up" },
            { 95, "Music: Left Right" },
            { 96, "Music: Left Down" },
            { 97, "Music: Left Left" },
            { 98, "Music: Right Up" },
            { 99, "Music: Right Right" },
            { 100, "Music: Right Down" },
            { 101, "Music: Right Left" },
            { 102, "Music: Note 1-1" },
            { 103, "Music: Note 1-2" },
            { 104, "Music: Note 1-3" },
            { 105, "Music: Note 1-4" },
            { 106, "Music: Note 1-5" },
            { 107, "Music: Note 1-6" },
            { 108, "Music: Note 1-7" },
            { 109, "Music: Note 2-1" },
            { 110, "Music: Note 2-2" },
            { 111, "Music: Note 2-3" },
            { 112, "Music: Note 2-4" },
            { 113, "Music: Note 2-5" },
            { 114, "Music: Note 2-6" },
            { 115, "Music: Note 2-7" },
            { 116, "Music: Note 3-1" },
            { 117, "Music: Note 3-2" },
            { 118, "Music: Note 3-3" },
            { 119, "Music: Note 3-4" },
            { 120, "Music: Note 3-5" },
            { 121, "Music: Note 3-6" },
            { 122, "Music: Note 3-7" },
            { 124, "F1?" },
            { 125, "F2?" },
            { 126, "F3?" },
            { 127, "Return?" },
            { 128, "Left Stick Move?" },
            { 129, "Pot Tasks" },
            { 130, "Pot Edit" },
            { 131, "Party Setup?" },
            { 132, "Friends" },
            { 133, "Pot Object: Turn Up?" },
            { 134, "Pot Object: Turn Down?" },
            { 135, "Pot Object: Turn Left?" },
            { 136, "Pot Object: Turn Right?" },
            { 137, "Right Stick Move?" },
            { 138, "LMB?" },
            { 139, "RMB?" },
            { 141, "Create Custom Suite?" },

        };

        public static Dictionary<int,string> keynames = new Dictionary<int, string>
        {
            { 0, "None" },
            { 55, "Backspace" },
            { 56, "Tab" },
            { 57, "Clear" },
            { 58, "Enter" },
            { 59, "Pause" },
            { 60, "ESC" },
            { 54, "Space" },
            { 66, "'" },
            { 78, "=" },
            { 71, "," },
            { 72, "-" },
            { 73, "." },
            { 74, "/" },
            { 27, "0" },
            { 28, "1" },
            { 29, "2" },
            { 30, "3" },
            { 31, "4" },
            { 32, "5" },
            { 33, "6" },
            { 34, "7" },
            { 35, "8" },
            { 36, "9" },
            { 76, ";" },
            { 82, "[" },
            { 83, "\\" },
            { 84, "]" },
            { 87, "~" },
            { 1, "A" },
            { 2, "B" },
            { 3, "C" },
            { 4, "D" },
            { 5, "E" },
            { 6, "F" },
            { 7, "G" },
            { 8, "H" },
            { 9, "I" },
            { 10, "J" },
            { 11, "K" },
            { 12, "L" },
            { 13, "M" },
            { 14, "N" },
            { 15, "O" },
            { 16, "P" },
            { 17, "Q" },
            { 18, "R" },
            { 19, "S" },
            { 20, "T" },
            { 21, "U" },
            { 22, "V" },
            { 23, "W" },
            { 24, "X" },
            { 25, "Y" },
            { 26, "Z" },
            { 88, "Delete" },
            { 37, "Numpad 0" },
            { 38, "Numpad 1" },
            { 39, "Numpad 2" },
            { 40, "Numpad 3" },
            { 41, "Numpad 4" },
            { 42, "Numpad 5" },
            { 43, "Numpad 6" },
            { 44, "Numpad 7" },
            { 45, "Numpad 8" },
            { 46, "Numpad 9" },
            { 47, "Numpad ." },
            { 48, "Numpad /" },
            { 49, "Numpad *" },
            { 50, "Numpad -" },
            { 51, "Numpad +" },
            { 89, "Arrow Up" },
            { 90, "Arrow Down" },
            { 91, "Arrow Right" },
            { 92, "Arrow Left" },
            { 93, "Insert" },
            { 94, "Home" },
            { 95, "End" },
            { 96, "Page Up" },
            { 97, "Page Down" },
            { 98, "F1" },
            { 99, "F2" },
            { 100, "F3" },
            { 101, "F4" },
            { 102, "F5" },
            { 103, "F6" },
            { 104, "F7" },
            { 105, "F8" },
            { 106, "F9" },
            { 107, "F10" },
            { 108, "F11" },
            { 109, "F12" },
            { 110, "F13" },
            { 111, "F14" },
            { 112, "F15" },
            { 113, "NumLock" },
            { 114, "CapsLock" },
            { 115, "ScrollLock" },
            { 116, "Right Shift" },
            { 117, "Left Shift" },
            { 118, "Right Ctrl" },
            { 119, "Left Ctrl" },
            { 120, "Right Alt" },
            { 121, "Left Alt" },
            { 125, "Right Win" },
            { 124, "Left Win" },
            { 127, "Help" },
            { 128, "Print" }
        };
        public static Dictionary<Keys, int> keyboard = new Dictionary<Keys, int>
        {
            { Keys.None, 0 },
            { Keys.Back, 55 },
            { Keys.Tab, 56 },
            { Keys.Clear, 57 },
            { Keys.Enter, 58 },
            { Keys.Pause, 59 },
            { Keys.Escape, 60 },
            { Keys.Space, 54 },
            // !   // Better to be mapped via 0-9 + Shift
            // "
            // #
            // $
            { Keys.OemQuotes, 66 },
            // (
            // )
            // *
            { Keys.Oemplus, 78 },
            { Keys.Oemcomma, 71 },
            { Keys.OemMinus, 72 },
            { Keys.OemPeriod, 73 },
            { Keys.OemQuestion, 74 },
            { Keys.D0, 27 },
            { Keys.D1, 28 },
            { Keys.D2, 29 },
            { Keys.D3, 30 },
            { Keys.D4, 31 },
            { Keys.D5, 32 },
            { Keys.D6, 33 },
            { Keys.D7, 34 },
            { Keys.D8, 35 },
            { Keys.D9, 36 },
            // :
            { Keys.OemSemicolon, 76 },
            // <
            // =
            // >
            // ?
            // @
            { Keys.OemOpenBrackets, 82 },
            { Keys.OemBackslash, 83 },
            { Keys.OemCloseBrackets, 84 },
            // ^
            // _
            { Keys.Oemtilde, 87 },
            { Keys.A, 1 },
            { Keys.B, 2 },
            { Keys.C, 3 },
            { Keys.D, 4 },
            { Keys.E, 5 },
            { Keys.F, 6 },
            { Keys.G, 7 },
            { Keys.H, 8 },
            { Keys.I, 9 },
            { Keys.J, 10 },
            { Keys.K, 11 },
            { Keys.L, 12 },
            { Keys.M, 13 },
            { Keys.N, 14 },
            { Keys.O, 15 },
            { Keys.P, 16 },
            { Keys.Q, 17 },
            { Keys.R, 18 },
            { Keys.S, 19 },
            { Keys.T, 20 },
            { Keys.U, 21 },
            { Keys.V, 22 },
            { Keys.W, 23 },
            { Keys.X, 24 },
            { Keys.Y, 25 },
            { Keys.Z, 26 },
            { Keys.Delete, 88 },
            { Keys.NumPad0, 37 },
            { Keys.NumPad1, 38 },
            { Keys.NumPad2, 39 },
            { Keys.NumPad3, 40 },
            { Keys.NumPad4, 41 },
            { Keys.NumPad5, 42 },
            { Keys.NumPad6, 43 },
            { Keys.NumPad7, 44 },
            { Keys.NumPad8, 45 },
            { Keys.NumPad9, 46 },
            { Keys.Decimal, 47 },
            { Keys.Divide, 48 },
            { Keys.Multiply, 49 },
            { Keys.Subtract, 50 },
            { Keys.Add, 51 },
            //{ Keys.NumpadEnter, 271 }, // No such key, hard to distinguish
            //{ Keys.NumpadEqual, 272 }, // Unavailable for some reason
            { Keys.Up, 89 },
            { Keys.Down, 90 },
            { Keys.Right, 91 },
            { Keys.Left, 92 },
            { Keys.Insert, 93 },
            { Keys.Home, 94 },
            { Keys.End, 95 },
            { Keys.PageUp, 96 },
            { Keys.PageDown, 97 },
            { Keys.F1, 98 },
            { Keys.F2, 99 },
            { Keys.F3, 100 },
            { Keys.F4, 101 },
            { Keys.F5, 102 },
            { Keys.F6, 103 },
            { Keys.F7, 104 },
            { Keys.F8, 105 },
            { Keys.F9, 106 },
            { Keys.F10, 107 },
            { Keys.F11, 108 },
            { Keys.F12, 109 },
            { Keys.F13, 110 },
            { Keys.F14, 111 },
            { Keys.F15, 112 },
            { Keys.NumLock, 113 },
            { Keys.CapsLock, 114 },
            { Keys.Scroll, 115 },
            { Keys.RShiftKey, 116 },
            { Keys.LShiftKey, 117 },
            { Keys.RControlKey, 118 },
            { Keys.LControlKey, 119 },
            { Keys.RMenu, 120 },
            { Keys.LMenu, 121 },
            // RCommand
            // LCommand
            { Keys.LWin, 124 },
            { Keys.RWin, 125 },
            // Alt Gr
            { Keys.Help, 127 },
            { Keys.Print, 128 },
            // SysRq
            // Break
            // Menu
        };
    }
}
