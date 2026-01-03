using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace MarriageOffersForPlayer
{
    public class Configs : AttributeGlobalSettings<Configs>
    {
        public override string Id => "MarriageOffersForPlayer";

        public override string DisplayName => "Marriage Offers For Player";

        public override string FolderName => "MarriageOffersForPlayer";

        public override string FormatType => "json2";

        private const string HeadingMarriageOffersForPlayer = "Marriage Offers For Player";

        [SettingPropertyBool(displayName: "Player receives marriage offers", Order = 1, RequireRestart = false, HintText = "Allows the player to receive marriage offer.")]
        [SettingPropertyGroup(HeadingMarriageOffersForPlayer)]
        public bool PlayerReceivesMarriageOffers { get; set; } = true;
		
		[SettingPropertyBool(displayName: "For Lords Only", Order = 2, RequireRestart = false, HintText = "Toggles whether or not the player recieves marriage proposals before or after becoming a lord that is part of kingdom.")]
        [SettingPropertyGroup(HeadingMarriageOffersForPlayer)]
        public bool MarriageOnlyWhenLord { get; set; } = false;
    }
}