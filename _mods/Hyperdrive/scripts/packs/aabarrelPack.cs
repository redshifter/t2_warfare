//--------------------------------------------------------------------------
// AA BARREL PACK: z0dd - ZOD, 5/18/03. All others inherit from this one
//--------------------------------------------------------------------------

datablock ShapeBaseImageData(AABarrelPackImage)
{
   mass = 10; // z0dd - ZOD, 7/17/02. Lower mass due to higher gravity. Was 15.
   className    = TurretPack;
   shapeFile  = "pack_barrel_aa.dts";
   item       = AABarrelPack;
   mountPoint = 1;
   offset     = "0 0 0";
   turretBarrel = "AABarrelLarge";

   stateName[0] = "Idle";
   stateTransitionOnTriggerDown[0] = "Activate";

   stateName[1] = "Activate";
   stateScript[1] = "onActivate";
   stateTransitionOnTriggerUp[1] = "Deactivate";

   stateName[2] = "Deactivate";
   stateScript[2] = "onDeactivate";
   stateTransitionOnTimeOut[2] = "Idle";

   isLarge = true;
};

datablock ItemData(AABarrelPack)
{
   className    = Pack;
   catagory     = "Packs";
   shapeFile    = "pack_barrel_aa.dts";
   mass         = 1;
   elasticity   = 0.2;
   friction     = 0.6;
   pickupRadius = 2;
   rotate       = true;
   image        = "AABarrelPackImage";
   pickUpName = "an anti-aircraft barrel pack";
   computeCRC = true;
};
