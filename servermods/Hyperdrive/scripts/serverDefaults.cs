$Host::useCustomSkins = 0;

$Host::teamSkin[0] = "blank";
$Host::teamSkin[1] = "base";
$Host::teamSkin[2] = "baseb";
$Host::teamSkin[3] = "swolf";
$Host::teamSkin[4] = "dsword";
$Host::teamSkin[5] = "beagle";
$Host::teamSkin[6] = "cotp";

$Host::teamName[0] = "Unassigned";
$Host::teamName[1] = "Storm";
$Host::teamName[2] = "Inferno";
$Host::teamName[3] = "Starwolf";
$Host::teamName[4] = "Diamond Sword";
$Host::teamName[5] = "Blood Eagle";
$Host::teamName[6] = "Phoenix";

$Host::holoName[0] = "";
$Host::holoName[1] = "Storm";
$Host::holoName[2] = "Inferno";
$Host::holoName[3] = "Starwolf";
$Host::holoName[4] = "DSword";
$Host::holoName[5] = "BloodEagle";
$Host::holoName[6] = "Harbinger";

// -----------------------------------------
// z0dd - ZOD, 9/29/02. Removed T2 demo code
$Host::GameName = "Tribes 2 Classic Server";
$Host::Info = "This is a Tribes 2 Classic Server.";
$Host::Map = "Katabatic";
$Host::MaxPlayers = 64;
// -----------------------------------------

// ------------------------------------------------
// z0dd - ZOD, 7/12/02. New admin feature variables
$Host::AdminPassword = "changethis";
$Host::ClassicSuperAdminPassword = "changeme";
$Host::ClassicAutoRestartServer = 0;                  // Automatically restart server, enable/disable
$Host::ClassicRestartTime = 12;                       // Time in hours to send quit to server
$Host::ClassicEchoChat = 0;                           // Print global chat to server console
$Host::ClassicTelnet = 0;                             // Enable/disable Telnet access to server
$Host::ClassicTelnetPort = 666;                       // Telnet port, must be open on host
$Host::ClassicTelnetPassword = "FullAccessPassword";  // Full access telnet password, can send commands to server
$Host::ClassicTelnetListenPass = "ListenOnyPassword"; // Read only telnet password, cannot send commands to server
$Host::ClassicLogEchoEnabled = 0;                     // Print special messages to server console
$Host::ClassicRandomMissions = 0;                     // Randomly load missions of the same type
$Host::ClassicMaxTelepads = 3;                        // How many special practice CTF pads each player gets
$Host::ClassicRandomizeTeams = 0;                     // Random team selection for players
$Host::ClassicFairTeams = 0;                          // Dissallow players from making teams uneven
$Host::ClassicAutoPWEnabled = 0;                      // Automatic join password setting of server after $Host::ClassicAutoPWPlayerCount is reached
$Host::ClassicAutoPWPassword = "changeit";            // $Host::Password changed to this if $Host::ClassicAutoPWEnabled is enabled
$Host::ClassicAutoPWPlayerCount = 30;                 // When server reaches this number of players, and $Host::ClassicAutoPWEnabled is enabled, join password set to $Host::ClassicAutoPWPassword
$Host::ClassicPacketRateToClient = 24;                // Packets per second sent to clients. Settings: modem 12, Cable 24, T1 32.
$Host::ClassicPacketSize = 400;                       // Size of packets sent to clients. Settings: modem 200, Cable 400, T1 450.
$Host::ClassicUseHighPerformanceCounter = 1;          // Setting to 0 will fix stuttering problem on dual processor servers.
$Host::ClassicLoadTR2Gametype = 0;                    // Option to not load Tr2 gametype
$Host::ClassicConnectLog = 1;                         // Logs all connections to prefs/*Connect.log
$Host::ClassicAntiTurtleTime = 6;                     // How many minutes after a stalemate in CTF are the flags returned
$Host::ClassicLimitArmors = 0;                        // Restrict armor types like turrets, larger team dictates amount avail
$Host::ClassicBadWordFilter = 0;                      // Replace potty mouths words with random garbage
$Host::ClassicTkLimit = 0;                            // When set to 5 or more and no admin is on server, a vote is started to kick the tker
$Host::ClassicAllowConsoleAccess = 0;                 // Allows super admins to use the servers console via Admin hud.
$Host::ClassicNoNullVoiceSpam = 0;                    // Allow or disallow NULL voice usage. 1 enabled NULL voice to be used.
$Host::ClassicBalancedBots = 0;                       // For every client join a bot is disconnected
$Host::ClassicCanKickBots = 0;                        // Allow/disallow vote kicking of bots
$Host::ClassicCycleMisTypes = 0;                      // Cycle to the next mission type every mission load
$Host::ClassicRandomMisTypes = 0;                     // Cycle to a random mission type every mission load
$Host::ClassicAdminLogPath = "prefs";                 // Path to save Admin log files
$Host::ClassicConnLogPath = "prefs";                  // Path to save Connection log files
$Host::ClassicLoadPlasmaTurretChanges = 0;            // Plasma turret does less damage and projectile si slower.
$Host::ClassicLoadHavocChanges = 0;                   // Havoc gets a built in sensor jammer with 20 meter radius.
$Host::ClassicLoadSniperChanges = 0;                  // Sniper Rifle uses ammo with 12 shots and energy.
$Host::ClassicLoadMissileChanges = 0;                 // Handheld missile launcher will not lock onto players and can no-lock fire.
$Host::ClassicLoadMortarChanges = 0;                  // Handheld mortar range limited to 450 meters.
$Host::ClassicLoadBlasterChanges = 0;                 // Blaster shoots 6 projectiles ala shotgun.
$Host::ClassicLoadPlayerChanges = 0;                  // Load up new gameplay changes allowing players to be shot while in vehicles.
$Host::ClassicLoadMineChanges = 0;                    // Enable/Disable mine disc.
$Host::ClassicLoadVRamChanges = 0;                    // Vehicles take damage when ramming players.
// ------------------------------------------------

$Host::AdminList = "";       // all players that will be automatically an admin upon joining server
$Host::SuperAdminList = "";  // all players that will be automatically a super admin upon joining server               
$Host::BindAddress = "";     // set to an ip address if the server wants to specify which NIC/IP to use                        
$Host::Port = 28000;
$Host::Password = "";
$Host::PureServer = 1;
$Host::Dedicated = 0;
$Host::MissionType = "CTF";
$Host::TimeLimit = 30;
$Host::BotCount = 2;
$Host::BotsEnabled = 0;
$Host::MinBotDifficulty = 0.5;
$Host::MaxBotDifficulty = 0.75;
$Host::NoSmurfs = 0;
$Host::VoteTime = 30;               // amount of time before votes are calculated
$Host::VotePassPercent = 60;        // percent needed to pass a vote
$Host::KickBanTime = 300;           // specified in seconds
$Host::BanTime = 1800;              // specified in seconds
$Host::PlayerRespawnTimeout = 60;   // time before a dead player is forced into observer mode
$Host::warmupTime = 20;
$Host::TournamentMode = 0;
$Host::allowAdminPlayerVotes = 1;
$Host::FloodProtectionEnabled = 1;
$Host::MaxMessageLen = 120;
$Host::VoteSpread = 20;
$Host::TeamDamageOn = 0;
$Host::Siege::Halftime = 20000;
$Host::CRCTextures = 0;

// 0: .v12 (1.2 kbits/sec), 1: .v24 (2.4 kbits/sec), 2: .v29 (2.9kbits/sec)
// 3:  GSM (6.6 kbits/sec)
$Audio::maxEncodingLevel = 3;
$Audio::maxVoiceChannels = 2;

$Host::MapPlayerLimits["Abominable", "CnH"] = "-1 -1";
$Host::MapPlayerLimits["AgentsOfFortune", "TeamHunters"] = "-1 32";
$Host::MapPlayerLimits["Alcatraz", "Siege"] = "-1 48";
$Host::MapPlayerLimits["Archipelago", "CTF"] = "16 -1";
$Host::MapPlayerLimits["AshesToAshes", "CnH"] = "16 -1";
$Host::MapPlayerLimits["BeggarsRun", "CTF"] = "-1 32";
$Host::MapPlayerLimits["Caldera", "Siege"] = "-1 48";
$Host::MapPlayerLimits["CasernCavite", "Hunters"] = "-1 32";
$Host::MapPlayerLimits["CasernCavite", "DM"] = "-1 32";
$Host::MapPlayerLimits["CasernCavite", "Bounty"] = "-1 32";
$Host::MapPlayerLimits["Damnation", "CTF"] = "-1 32";
$Host::MapPlayerLimits["DeathBirdsFly", "CTF"] = "8 -1";
$Host::MapPlayerLimits["Desiccator", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["DustToDust", "CTF"] = "-1 32";
$Host::MapPlayerLimits["DustToDust", "Hunters"] = "-1 32";
$Host::MapPlayerLimits["DustToDust", "TeamHunters"] = "-1 32";
$Host::MapPlayerLimits["Equinox", "CnH"] = "-1 -1";
$Host::MapPlayerLimits["Equinox", "DM"] = "-1 32";
$Host::MapPlayerLimits["Escalade", "Hunters"] = "8 -1";
$Host::MapPlayerLimits["Escalade", "TeamHunters"] = "8 -1";
$Host::MapPlayerLimits["Escalade", "DM"] = "16 -1";
$Host::MapPlayerLimits["Escalade", "Bounty"] = "16 32";
$Host::MapPlayerLimits["Escalade", "Rabbit"] = "16 -1";
$Host::MapPlayerLimits["Firestorm", "CTF"] = "-1 24";
$Host::MapPlayerLimits["Firestorm", "CnH"] = "-1 24";
$Host::MapPlayerLimits["Flashpoint", "CnH"] = "-1 -1";
$Host::MapPlayerLimits["Gauntlet", "Siege"] = "-1 32";
$Host::MapPlayerLimits["Gehenna", "Hunters"] = "-1 -1";
$Host::MapPlayerLimits["Gehenna", "TeamHunters"] = "-1 -1";
$Host::MapPlayerLimits["Icebound", "Siege"] = "-1 -1";
$Host::MapPlayerLimits["Insalubria", "CnH"] = "-1 32";
$Host::MapPlayerLimits["JacobsLadder", "CnH"] = "-1 -1";
$Host::MapPlayerLimits["Katabatic", "CTF"] = "-1 48";
$Host::MapPlayerLimits["Masada", "Siege"] = "-1 32";
$Host::MapPlayerLimits["Minotaur", "CTF"] = "-1 32";
$Host::MapPlayerLimits["Myrkwood", "Hunters"] = "-1 32";
$Host::MapPlayerLimits["Myrkwood", "DM"] = "-1 32";
$Host::MapPlayerLimits["Myrkwood", "Rabbit"] = "-1 32";
$Host::MapPlayerLimits["Oasis", "DM"] = "-1 32";
$Host::MapPlayerLimits["Overreach", "CnH"] = "8 -1";
$Host::MapPlayerLimits["Quagmire", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["Rasp", "TeamHunters"] = "-1 32";
$Host::MapPlayerLimits["Rasp", "Bounty"] = "-1 32";
$Host::MapPlayerLimits["Recalescence", "CTF"] = "16 -1";
$Host::MapPlayerLimits["Respite", "Siege"] = "-1 32";
$Host::MapPlayerLimits["Reversion", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["Rimehold", "Hunters"] = "8 -1";
$Host::MapPlayerLimits["Rimehold", "Hunters"] = "8 -1";
$Host::MapPlayerLimits["Riverdance", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["Sanctuary", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["Sirocco", "CnH"] = "8 -1";
$Host::MapPlayerLimits["Slapdash", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["SunDried", "DM"] = "8 -1";
$Host::MapPlayerLimits["SunDried", "Bounty"] = "8 -1";
$Host::MapPlayerLimits["Talus", "Bounty"] = "-1 32";
$Host::MapPlayerLimits["ThinIce", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["Tombstone", "CTF"] = "-1 -1";
$Host::MapPlayerLimits["UltimaThule", "Siege"] = "8 -1";
$Host::MapPlayerLimits["Underhill", "DM"] = "-1 -1";
$Host::MapPlayerLimits["Underhill", "Bounty"] = "-1 32";
$Host::MapPlayerLimits["Whiteout", "DM"] = "8 -1";
$Host::MapPlayerLimits["Whiteout", "Bounty"] = "8 -1";
