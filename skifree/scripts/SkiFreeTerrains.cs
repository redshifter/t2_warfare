// SkiFree Terrain List
// Generation Date: 2021-03-13 23:54:52

// A good terrain has the following qualities:
// - doesn't have a bunch of flat ground, even if it's right outside the mission bounds (high octane)
// - is not fucking gigantic (stripmine, a bunch of other TR2 terrains)
// - doesn't have a bunch of steep plateaus
// - is not Magnum (a map where the fastest route is to discjump off a bunch of flat ridges)
// use $TerrainTest to test a terrain locally

%i = -1; // %i++ is pre-increment for some reason; it's -1 so it can start at 0

// ACCEPTED TERRAINS (83)
$SkiFreeTerrainList[%i++] = "Alcatraz.ter"; // yeah. seems fine
$SkiFreeTerrainList[%i++] = "Attrition.ter";
$SkiFreeTerrainList[%i++] = "BastardForge.ter";
$SkiFreeTerrainList[%i++] = "Broadside_nef.ter";
$SkiFreeTerrainList[%i++] = "Caldera.ter";
$SkiFreeTerrainList[%i++] = "Cardiac.ter";
$SkiFreeTerrainList[%i++] = "CCD.ter";
$SkiFreeTerrainList[%i++] = "CeleritySE.ter"; // I was on the fence on this one
$SkiFreeTerrainList[%i++] = "Cinerarium.ter";
$SkiFreeTerrainList[%i++] = "Coppera.ter"; // this seems fine. just gotta keep jumping over the mesas? plateaus? fjordr? Whatever
$SkiFreeTerrainList[%i++] = "DangerousCrossing_nef.ter"; // this level is fine
$SkiFreeTerrainList[%i++] = "DeathBirdsFly.ter";
$SkiFreeTerrainList[%i++] = "DesertofDeath_nef.ter";
$SkiFreeTerrainList[%i++] = "Embers.ter";
$SkiFreeTerrainList[%i++] = "Euro4_Bleed.ter";
$SkiFreeTerrainList[%i++] = "Euro4_Dissention.ter";
$SkiFreeTerrainList[%i++] = "Euro4_FrozenHope.ter"; // seems fine?
$SkiFreeTerrainList[%i++] = "Gorgon.ter";
$SkiFreeTerrainList[%i++] = "Hildebrand.ter";
$SkiFreeTerrainList[%i++] = "icedagger.ter";
$SkiFreeTerrainList[%i++] = "jaggedclaw.ter";
$SkiFreeTerrainList[%i++] = "LavaGods.ter"; // this is fine
$SkiFreeTerrainList[%i++] = "Magellan.ter";
$SkiFreeTerrainList[%i++] = "Magmatic.ter"; // a bit on the hard side
$SkiFreeTerrainList[%i++] = "Oasis.ter";
$SkiFreeTerrainList[%i++] = "Ocular.ter";
$SkiFreeTerrainList[%i++] = "PlanetX2.ter";
$SkiFreeTerrainList[%i++] = "Raindance_nef.ter";
$SkiFreeTerrainList[%i++] = "RandomTer1.ter";
$SkiFreeTerrainList[%i++] = "RandomTer10.ter";
$SkiFreeTerrainList[%i++] = "RandomTer2.ter";
$SkiFreeTerrainList[%i++] = "RandomTer4.ter";
$SkiFreeTerrainList[%i++] = "RandomTer5.ter";
$SkiFreeTerrainList[%i++] = "RandomTer6.ter";
$SkiFreeTerrainList[%i++] = "RandomTer7.ter";
$SkiFreeTerrainList[%i++] = "RandomTer8.ter";
$SkiFreeTerrainList[%i++] = "RandomTer9.ter"; // this canyon works somehow
$SkiFreeTerrainList[%i++] = "Respite.ter";
$SkiFreeTerrainList[%i++] = "Rollercoaster_nef.ter"; // unlike most canyon maps this actually turns out to be skiiable
$SkiFreeTerrainList[%i++] = "rst_Astro.ter";
$SkiFreeTerrainList[%i++] = "rst_bittergorge.ter";
$SkiFreeTerrainList[%i++] = "rst_crumpie.ter";
$SkiFreeTerrainList[%i++] = "rst_FaceCrossing.ter";
$SkiFreeTerrainList[%i++] = "Rst_ScorchedEarth.ter"; // it's fine
$SkiFreeTerrainList[%i++] = "rst_spit.ter"; // i got to gate 5 on a discless discjump launch run
$SkiFreeTerrainList[%i++] = "Rush.ter";
$SkiFreeTerrainList[%i++] = "S5_Centaur.ter";
$SkiFreeTerrainList[%i++] = "S5_Drache.ter";
$SkiFreeTerrainList[%i++] = "S5_Icedance.ter";
$SkiFreeTerrainList[%i++] = "S5_massive.ter"; // this is fine? I remember writing about deadstops but I don't see any?
$SkiFreeTerrainList[%i++] = "S5_Mordacity.ter";
$SkiFreeTerrainList[%i++] = "S5_rst_misadventure.ter";
$SkiFreeTerrainList[%i++] = "S5_Sherman.ter";
$SkiFreeTerrainList[%i++] = "S8_rst_dogma.ter";
$SkiFreeTerrainList[%i++] = "S8_rst_opus.ter";
$SkiFreeTerrainList[%i++] = "Sandstorm.ter";
$SkiFreeTerrainList[%i++] = "SkinnyDip.ter"; // really wanted to use one of the TR2 maps. This has a big scale but also nice hills
$SkiFreeTerrainList[%i++] = "SpinCycle.ter"; // this was borderline rejected
$SkiFreeTerrainList[%i++] = "StarFallCTF2.ter";
$SkiFreeTerrainList[%i++] = "Starfallen.ter";
$SkiFreeTerrainList[%i++] = "TL_Drorck.ter";
$SkiFreeTerrainList[%i++] = "TL_RoughLand.ter"; // this is kinda a finicky terrain but it works
$SkiFreeTerrainList[%i++] = "Tombstone.ter";
$SkiFreeTerrainList[%i++] = "TWL-BeachBlitz.ter";
$SkiFreeTerrainList[%i++] = "TWL-Boss.ter"; // this level is acceptable
$SkiFreeTerrainList[%i++] = "TWL-Cinereous.ter";
$SkiFreeTerrainList[%i++] = "TWL-Damnation.ter";
$SkiFreeTerrainList[%i++] = "TWL-Deserted.ter";
$SkiFreeTerrainList[%i++] = "TWL-Frozen.ter";
$SkiFreeTerrainList[%i++] = "TWL-Harvester.ter"; // why did I take this one
$SkiFreeTerrainList[%i++] = "TWL-Os_Iris.ter";
$SkiFreeTerrainList[%i++] = "TWL-Pandemonium.ter";
$SkiFreeTerrainList[%i++] = "TWL-WilderZone.ter";
$SkiFreeTerrainList[%i++] = "TWL-WoodyMyrk.ter";
$SkiFreeTerrainList[%i++] = "TWL2_Crevice.ter";
$SkiFreeTerrainList[%i++] = "TWL2_Frozenglory.ter";
$SkiFreeTerrainList[%i++] = "Wasteland.ter"; // whatever sure
$SkiFreeTerrainList[%i++] = "WoodyMyrkSE.ter";
$SkiFreeTerrainList[%i++] = "Xtra_AshenPowder.ter"; // massive flat area is in a place the player would want to discjump over anyway
$SkiFreeTerrainList[%i++] = "Xtra_Bastage.ter";
$SkiFreeTerrainList[%i++] = "Xtra_SoupLadle.ter";
$SkiFreeTerrainList[%i++] = "Xtra_ThunderGiant.ter"; // this map is garbage but it's fun to try to ski on it
$SkiFreeTerrainList[%i++] = "Xtra_VanDamned.ter";

// REJECTED FOR DEADSTOPS (65)
//$SkiFreeTerrainList[%i++] = "Abominable.ter";
//$SkiFreeTerrainList[%i++] = "AcidRain.ter";
//$SkiFreeTerrainList[%i++] = "AgentsOfFortune.ter";
//$SkiFreeTerrainList[%i++] = "AshesToAshes.ter";
//$SkiFreeTerrainList[%i++] = "Casern_Cavite.ter";
//$SkiFreeTerrainList[%i++] = "DBS_Smoothed.ter";
//$SkiFreeTerrainList[%i++] = "DustToDust.ter";
//$SkiFreeTerrainList[%i++] = "Equinox.ter";
//$SkiFreeTerrainList[%i++] = "Extra_Badlands1.ter";
//$SkiFreeTerrainList[%i++] = "Firestorm.ter";
//$SkiFreeTerrainList[%i++] = "Flashpoint.ter";
//$SkiFreeTerrainList[%i++] = "Fracas.ter";
//$SkiFreeTerrainList[%i++] = "Gauntlet.ter";
//$SkiFreeTerrainList[%i++] = "Gehenna.ter";
//$SkiFreeTerrainList[%i++] = "Haven.ter";
//$SkiFreeTerrainList[%i++] = "Hillside.ter";
//$SkiFreeTerrainList[%i++] = "HO_Badlands.ter";
//$SkiFreeTerrainList[%i++] = "HO_Desert.ter";
//$SkiFreeTerrainList[%i++] = "HO_Ice.ter";
//$SkiFreeTerrainList[%i++] = "HO_Lush.ter";
//$SkiFreeTerrainList[%i++] = "IceBound.ter";
//$SkiFreeTerrainList[%i++] = "Invictus.ter";
//$SkiFreeTerrainList[%i++] = "MapAssets.ter";
//$SkiFreeTerrainList[%i++] = "Masada.ter"; // tiny dicked map
//$SkiFreeTerrainList[%i++] = "mmd.ter";
//$SkiFreeTerrainList[%i++] = "MoonDance2.ter"; // too many deadstop splotches
//$SkiFreeTerrainList[%i++] = "Octane.ter";
//$SkiFreeTerrainList[%i++] = "Overreach.ter";
//$SkiFreeTerrainList[%i++] = "PhasmaDust.ter";
//$SkiFreeTerrainList[%i++] = "Pyroclasm.ter";
//$SkiFreeTerrainList[%i++] = "Quagmire.ter";
//$SkiFreeTerrainList[%i++] = "Recalescence.ter";
//$SkiFreeTerrainList[%i++] = "Reversion.ter";
//$SkiFreeTerrainList[%i++] = "RiverDance.ter";
//$SkiFreeTerrainList[%i++] = "rst_isledebatalla.ter";
//$SkiFreeTerrainList[%i++] = "SC_Badlands.ter";
//$SkiFreeTerrainList[%i++] = "SC_Desert.ter";
//$SkiFreeTerrainList[%i++] = "SC_Ice.ter";
//$SkiFreeTerrainList[%i++] = "SC_Lush.ter";
//$SkiFreeTerrainList[%i++] = "SC_Night.ter";
//$SkiFreeTerrainList[%i++] = "SC_Normal.ter";
//$SkiFreeTerrainList[%i++] = "Scarabrae_nef.ter";
//$SkiFreeTerrainList[%i++] = "Sirocco.ter";
//$SkiFreeTerrainList[%i++] = "SolsDescent.ter";
//$SkiFreeTerrainList[%i++] = "SunDried.ter";
//$SkiFreeTerrainList[%i++] = "ThinIce.ter";
//$SkiFreeTerrainList[%i++] = "TL_MuddySwamp.ter";
//$SkiFreeTerrainList[%i++] = "Training1.ter";
//$SkiFreeTerrainList[%i++] = "Training2.ter";
//$SkiFreeTerrainList[%i++] = "Training3.ter";
//$SkiFreeTerrainList[%i++] = "Training4.ter";
//$SkiFreeTerrainList[%i++] = "TreasureIsland.ter";
//$SkiFreeTerrainList[%i++] = "TWL_Crossfire.ter";
//$SkiFreeTerrainList[%i++] = "TWL-BaNsHee.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Curtilage.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Horde.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Katabatic.ter"; // oob still bad
//$SkiFreeTerrainList[%i++] = "TWL-Neve.ter"; // it's trace amounts but they're in places you would probably do routes
//$SkiFreeTerrainList[%i++] = "TWL-NoShelter.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Slapdash.ter"; // crapdash
//$SkiFreeTerrainList[%i++] = "TWL2_Ruined.ter"; // looks like a decent terrain but isn’t
//$SkiFreeTerrainList[%i++] = "Tyre.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_StarFall_T1.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_Stripmine.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_ziggurat.ter";

// REJECTED FOR BEING UNSKIIABLE (60)
//$SkiFreeTerrainList[%i++] = "Archipelago.ter";
//$SkiFreeTerrainList[%i++] = "Bunkered.ter";
//$SkiFreeTerrainList[%i++] = "cloak.ter"; // the terrain is just too big for a fun race
//$SkiFreeTerrainList[%i++] = "CompUSA_Melee.ter"; // the hill is just causing too much grief
//$SkiFreeTerrainList[%i++] = "Confusco.ter"; // WAY too big.
//$SkiFreeTerrainList[%i++] = "Crater71.ter"; // this almost always generates something very unfun
//$SkiFreeTerrainList[%i++] = "EB_Hades.ter"; // not only is it extreme but you kinda have trouble reading the terrain too
//$SkiFreeTerrainList[%i++] = "Escalade.ter";
//$SkiFreeTerrainList[%i++] = "Euro_Drifts_SE.ter";
//$SkiFreeTerrainList[%i++] = "FrozenFury.ter"; // even the parts inside mission bounds are unskiiable garbage
//$SkiFreeTerrainList[%i++] = "Geothermal.ter"; // spawn is usually on the plateau. It can generate good starts and bad starts but it's usually a mess
//$SkiFreeTerrainList[%i++] = "GodsRift.ter";
//$SkiFreeTerrainList[%i++] = "HillKing.ter";
//$SkiFreeTerrainList[%i++] = "Hoth.ter"; // why would you name a terrain hoth if it isn't snowy
//$SkiFreeTerrainList[%i++] = "IceGiant.ter"; // terrain is kinda extreme
//$SkiFreeTerrainList[%i++] = "IceRidge_nef.ter"; // canyons are just bad for this
//$SkiFreeTerrainList[%i++] = "Insalubria.ter";
//$SkiFreeTerrainList[%i++] = "JacobsLadder.ter"; // hills are WAY too extreme
//$SkiFreeTerrainList[%i++] = "Minotaur.ter";
//$SkiFreeTerrainList[%i++] = "mountking.ter";
//$SkiFreeTerrainList[%i++] = "norty.ter"; // too extreme
//$SkiFreeTerrainList[%i++] = "Pariah.ter"; // these hills are too fucking steep
//$SkiFreeTerrainList[%i++] = "Pariah2.ter"; // ditto
//$SkiFreeTerrainList[%i++] = "PuliVeivari.ter";
//$SkiFreeTerrainList[%i++] = "RandomTer3.ter"; // canyon fractal
//$SkiFreeTerrainList[%i++] = "Rasp.ter";
//$SkiFreeTerrainList[%i++] = "RavineV.ter";
//$SkiFreeTerrainList[%i++] = "Rimehold.ter";
//$SkiFreeTerrainList[%i++] = "rst_SimpleFlagArena.ter";
//$SkiFreeTerrainList[%i++] = "S5_rst_hawkingheat.ter";
//$SkiFreeTerrainList[%i++] = "S5_rst_reynard.ter"; // this map is pushing the bounds of variance
//$SkiFreeTerrainList[%i++] = "S5_rst_silenus.ter";
//$SkiFreeTerrainList[%i++] = "S8_zilch.ter";
//$SkiFreeTerrainList[%i++] = "Sanctuary.ter";
//$SkiFreeTerrainList[%i++] = "ShockRidge.ter"; // not a fan of these canyon levels
//$SkiFreeTerrainList[%i++] = "Snowblind_nef.ter"; // already knew this is a bad idea before I even started
//$SkiFreeTerrainList[%i++] = "Stonehenge_nef.ter"; // kryand tried to tell me this was a skiiable terrain. so I put the flags in different places. He no longer believes it's a skiiable terrain
//$SkiFreeTerrainList[%i++] = "Surreal.ter";
//$SkiFreeTerrainList[%i++] = "Talus.ter";
//$SkiFreeTerrainList[%i++] = "Titan.ter"; // why did I even open this
//$SkiFreeTerrainList[%i++] = "TL_Skylight.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Abaddon.ter";
//$SkiFreeTerrainList[%i++] = "TWL-BeggarsRun.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Chokepoint.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Clusterfuct.ter";
//$SkiFreeTerrainList[%i++] = "TWL-DeadlyBirdsSong.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Desiccator.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Euro_Feign.ter"; // come on man
//$SkiFreeTerrainList[%i++] = "TWL-Frostclaw.ter";
//$SkiFreeTerrainList[%i++] = "TWL-Runenmacht.ter"; // nah
//$SkiFreeTerrainList[%i++] = "TWL-SubZero.ter";
//$SkiFreeTerrainList[%i++] = "UltimaThule.ter";
//$SkiFreeTerrainList[%i++] = "Underhill.ter";
//$SkiFreeTerrainList[%i++] = "WhiteDwarf.ter";
//$SkiFreeTerrainList[%i++] = "Whiteout.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_Birthright.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_Crown.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_DesertedSE.ter"; // This is a VERY jagged terrain.
//$SkiFreeTerrainList[%i++] = "Xtra_Voodoo.ter";
//$SkiFreeTerrainList[%i++] = "Xtra_Xerxes.ter";

// REJECTED FOR SOME OTHER REASON (13)
//$SkiFreeTerrainList[%i++] = "Chasmaclysmic.ter"; // this level is really kinda boring if it spawns right (which it can not do)
//$SkiFreeTerrainList[%i++] = "DMP_Pantheon.ter"; // there isn't enough value to this map to risk deadstopping
//$SkiFreeTerrainList[%i++] = "Lakefront.ter"; // just kinda hate this map tbh
//$SkiFreeTerrainList[%i++] = "Moonwalk.ter"; // magnum-like terrain
//$SkiFreeTerrainList[%i++] = "MyrkWood.ter"; // we don't need this when we have woodymyrk
//$SkiFreeTerrainList[%i++] = "Paranoia.ter"; // this map is basically flat garbage with a few hills to get in your way
//$SkiFreeTerrainList[%i++] = "Ramparts.ter"; // biased against copyright violation map
//$SkiFreeTerrainList[%i++] = "rst_agroleon.ter"; // the outer half of the terrain is too flat. and I deadstopped somewhere weird
//$SkiFreeTerrainList[%i++] = "rst_dermcity.ter"; // whatever the fuck this is doesn't seem good for this
//$SkiFreeTerrainList[%i++] = "TL_Magnum.ter"; // the best route is “discjump and keep landing on the flat parts at the top” – this is not compelling gameplay
//$SkiFreeTerrainList[%i++] = "Training5.ter"; // Terrain is WAY too dark and you can't tell features on it.
//$SkiFreeTerrainList[%i++] = "TWL-Drifts.ter"; // there's nothing really to this map outside the mission bounds
//$SkiFreeTerrainList[%i++] = "Xtra_Helion.ter"; // this is just a really boring terrain

// DUPLICATES (14)
//$SkiFreeTerrainList[%i++] = "BeggarsRun.ter";
//$SkiFreeTerrainList[%i++] = "Damnation.ter";
//$SkiFreeTerrainList[%i++] = "Desiccator.ter"; // Things clearly seem to be at 4 plateaus of height. which doesn't make for good skiing.
//$SkiFreeTerrainList[%i++] = "DX_Badlands.ter";
//$SkiFreeTerrainList[%i++] = "DX_Desert.ter";
//$SkiFreeTerrainList[%i++] = "DX_Ice.ter";
//$SkiFreeTerrainList[%i++] = "Katabatic.ter";
//$SkiFreeTerrainList[%i++] = "Ravine.ter";
//$SkiFreeTerrainList[%i++] = "S5-Icedance.ter";
//$SkiFreeTerrainList[%i++] = "S5-massive.ter";
//$SkiFreeTerrainList[%i++] = "S5-Mordacity.ter";
//$SkiFreeTerrainList[%i++] = "Slapdash.ter";
//$SkiFreeTerrainList[%i++] = "SubZero.ter";
//$SkiFreeTerrainList[%i++] = "TWL-BlueMoon.ter";

TWL-BlueMoon.ter";

 = "TWL-BlueMoon.ter";

