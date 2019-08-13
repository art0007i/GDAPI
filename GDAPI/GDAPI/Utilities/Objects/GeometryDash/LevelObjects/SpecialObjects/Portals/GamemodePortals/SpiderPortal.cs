﻿using GDAPI.Utilities.Attributes;
using GDAPI.Utilities.Enumerations.GeometryDash;
using GDAPI.Utilities.Functions.GeometryDash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPI.Utilities.Objects.GeometryDash.LevelObjects.SpecialObjects.Portals.GamemodePortals
{
    /// <summary>Represents a spider portal.</summary>
    [ObjectID(PortalType.Spider)]
    public class SpiderPortal : CheckableGamemodePortal
    {
        /// <summary>The object ID of the spider portal.</summary>
        [ObjectStringMappable(ObjectParameter.ID)]
        public override int ObjectID => (int)PortalType.Spider;
        /// <summary>The gamemode the gamemode portal transforms the player into.</summary>
        public override Gamemode Gamemode => Gamemode.Spider;

        /// <summary>Initializes a new instance of the <seealso cref="SpiderPortal"/> class.</summary>
        public SpiderPortal() : base() { }

        /// <summary>Returns a clone of this <seealso cref="SpiderPortal"/>.</summary>
        public override GeneralObject Clone() => AddClonedInstanceInformation(new SpiderPortal());
    }
}
