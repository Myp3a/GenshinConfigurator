import winreg
import json

gensh = winreg.OpenKeyEx(winreg.HKEY_CURRENT_USER,"SOFTWARE\miHoYo\Genshin Impact",access=winreg.KEY_ALL_ACCESS)
err = False
i = 0
while not err:
    try:
        key = winreg.EnumValue(gensh,i)
        if "GENERAL_DATA" in key[0]:
            gdata = key
            break
        i += 1
    except:
        err = True

if err:
    print("Settings key not found!")
else:
    noend = gdata[1][:-1] # There is a null character at the end
    settings = json.loads(noend)
    print(settings)