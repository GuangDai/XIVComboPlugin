using XIVComboExpandedPlugin.Attributes;
using XIVComboExpandedPlugin.Combos;

namespace XIVComboExpandedPlugin;

/// <summary>
/// Combo presets.
/// </summary>
public enum CustomComboPreset
{
    // ====================================================================================
    #region Misc

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
    AdvAny = 0,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
    AstAny = AdvAny + AST.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
    BlmAny = AdvAny + BLM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
    BrdAny = AdvAny + BRD.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
    DncAny = AdvAny + DNC.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
    DohAny = AdvAny + DOH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
    DolAny = AdvAny + DOL.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
    DrgAny = AdvAny + DRG.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
    DrkAny = AdvAny + DRK.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
    GnbAny = AdvAny + GNB.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
    MchAny = AdvAny + MCH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
    MnkAny = AdvAny + MNK.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
    NinAny = AdvAny + NIN.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
    PldAny = AdvAny + PLD.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
    RdmAny = AdvAny + RDM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
    RprAny = AdvAny + RPR.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
    SamAny = AdvAny + SAM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
    SchAny = AdvAny + SCH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
    SgeAny = AdvAny + SGE.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
    SmnAny = AdvAny + SMN.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
    WarAny = AdvAny + WAR.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
    WhmAny = AdvAny + WHM.JobID,

    [CustomComboInfo("Disabled", "This should not be used.", ADV.JobID)]
    Disabled = 99999,

    #endregion
    // ====================================================================================
    #region ADV

    [CustomComboInfo("Swift Raise Feature", "Replace Ascend, Ressurection, Egeiro, Raise, Verraise, and Angel Whisper with Swiftcast when it is off cooldown (and Dualcast isn't up).", ADV.JobID)]
    AdvSwiftcastFeature = 1000,

    [CustomComboInfo("Variant Raise Feature", "Replace Ascend, Ressurection, Egeiro, Raise, Verraise, and Angel Whisper with Variant Raise II when in a variant dungeon.", ADV.JobID)]
    AdvVariantRaiseFeature = 1001,

    #endregion
    // ====================================================================================
    #region ASTROLOGIAN

    [CustomComboInfo("Malefic to Draw", "Replace Malefic with Draw when no card is drawn and a card is available. 当没有抽到卡且有卡可用时，将凶星替换为抽卡。", AST.JobID)]
    AstrologianMaleficDrawFeature = 3309,

    [CustomComboInfo("Gravity to Draw", "Replace Gravity with Draw when no card is drawn and a card is available. 当没有抽到卡且有卡可用时，将重力替换为抽卡。", AST.JobID)]
    AstrologianGravityDrawFeature = 3310,

    [CustomComboInfo("Play to Draw", "Replace Play with Draw when no card is drawn and a card is available. 当没有抽到卡且有卡可用时，将出卡替换为抽卡。", AST.JobID)]
    AstrologianPlayDrawFeature = 3301,

    [ParentCombo(AstrologianPlayDrawFeature)]
    [CustomComboInfo("Play to Draw to Astrodyne", "Replace Play with Astrodyne when seals are full and Draw is on cooldown or a card is drawn. 当封印满且抽卡在冷却或已抽到卡时，将出卡替换为星力。", AST.JobID)]
    AstrologianPlayDrawAstrodyneFeature = 3307,

    [CustomComboInfo("Play to Redraw", "Replace Play with Redraw if a card is drawn and would grant a seal you already have. 如果已抽到卡并且会获得你已有的封印，将出卡替换为重抽。", AST.JobID)]
    AstrologianPlayRedrawFeature = 3311,

    [CustomComboInfo("Play to Astrodyne", "Replace Play with Astrodyne when seals are full. 当封印满时，将出卡替换为星力。", AST.JobID)]
    AstrologianPlayAstrodyneFeature = 3304,

    [CustomComboInfo("Draw Lockout", "Replace Draw (not Play to Draw) with Malefic when a card is drawn. 当已抽到卡时，将抽卡(不是出卡转抽卡)替换为凶星。", AST.JobID)]
    AstrologianDrawLockoutFeature = 3306,

    [CustomComboInfo("Benefic 2 to Benefic Level Sync", "Replace Benefic 2 with Benefic when below level 26 in synced content. 在同步内容中低于26级时，将福星II替换为福星。", AST.JobID)]
    AstrologianBeneficSyncFeature = 3303,

    #endregion
    // ====================================================================================
    #region BLACK MAGE

    [CustomComboInfo("Enochian Feature", "Replace Fire 4 and Blizzard 4 with whichever action you can currently use. 将炽炎和冰澈替换为你当前可以使用的技能。", BLM.JobID)]
    BlackEnochianFeature = 2501,

    [SecretCustomCombo]
    [ParentCombo(BlackEnochianFeature)]
    [CustomComboInfo("Enochian Despair Feature", "Replace Fire 4 and Blizzard 4 with Despair when in Astral Fire with less than 2400 mana. 在星灵火焰状态下魔力少于2400时，将炽炎和冰澈替换为绝望。", BLM.JobID)]
    BlackEnochianDespairFeature = 2510,

    [ParentCombo(BlackEnochianFeature)]
    [CustomComboInfo("Enochian No Sync Feature", "Fire 4 and Blizzard 4 will not sync to Fire 1 and Blizzard 1. 炽炎和冰澈不会与火炎和冰结同步。", BLM.JobID)]
    BlackEnochianNoSyncFeature = 2518,

    [CustomComboInfo("Transpose into Umbral Soul", "Replace Transpose with Umbral Soul when Umbral Soul is usable. 当灵极魂可用时，将星灵移位替换为灵极魂。", BLM.JobID)]
    BlackTransposeUmbralSoulFeature = 2502,

    [CustomComboInfo("Umbral Soul into Transpose", "Replace Umbral Soul with Transpose when Umbral Soul is not usable. 当灵极魂不可用时，将灵极魂替换为星灵移位。", BLM.JobID)]
    BlackUmbralSoulTransposeFeature = 2522,

    [CustomComboInfo("(Between the) Ley Lines", "Replace Ley Lines with BTL when Ley Lines is active. 当黑魔纹激活时，将其替换为魔纹步。", BLM.JobID)]
    BlackLeyLinesFeature = 2503,

    [CustomComboInfo("Fire 1/3 Feature", "Fire 1 becomes Fire 3 outside of Astral Fire, and when Firestarter is up. 火炎1在星灵火焰外变为爆炎，并在火苗激活时变为爆炎。", BLM.JobID)]
    BlackFireFeature = 2504,

    [ParentCombo(BlackFireFeature)]
    [CustomComboInfo("Fire 1/3 Option", "Fire 1 will stay Fire 3 when not at max Astral Fire. 火炎1在非最大星灵火焰时保持为爆炎。", BLM.JobID)]
    BlackFireOption = 2515,

    [ParentCombo(BlackFireFeature)]
    [CustomComboInfo("Fire 1/3 Option (2)", "Fire 1 does not become Fire 3 outside of Astral Fire. 火炎1在星灵火焰外不变为爆炎。", BLM.JobID)]
    BlackFireOption2 = 2516,

    [CustomComboInfo("Blizzard 1/3 Feature", "Replace Blizzard 1 with Blizzard 3 when unlocked and becomes Paradox when available. 当解锁时，将冰结1替换为冰封，并在悖论可用时变为悖论。", BLM.JobID)]
    BlackBlizzardFeature = 2505,

    [ParentCombo(BlackBlizzardFeature)]
    [CustomComboInfo("Paradox only during Umbral Ice", "Only replace Blizzard with Paradox during Umbral Ice. 仅在星灵冰结期间将冰结替换为悖论。", BLM.JobID)]
    BlackBlizzardParadoxOption = 2521,

    [CustomComboInfo("Freeze/Flare Feature", "Freeze and Flare become whichever action you can currently use. 玄冰和核爆变为你当前可以使用的技能。", BLM.JobID)]
    BlackFreezeFlareFeature = 2506,

    [CustomComboInfo("Fire 2 Feature", "(High) Fire 2 becomes Flare in Astral Fire when only 1 Umbral Heart is active, less than 3000 mp, or during Enhanced Flare. 在星灵火焰中，当只有1个星灵之心激活、魔力少于3000或在核爆效果提高期间，(高)火炎2变为核爆。", BLM.JobID)]
    BlackFire2Feature = 2508,

    [ParentCombo(BlackFire2Feature)]
    [CustomComboInfo("Fire 2 Triplecast Option", "Shorten rotation when Triplecast is active to make both Flare casts instant. 当三连咏唱激活时缩短循环，使两次核爆施放瞬发。", BLM.JobID)]
    BlackFire2TriplecastOption = 2523,

    [CustomComboInfo("Ice 2 Feature", "(High) Blizzard 2 becomes Freeze in Umbral Ice. 在星灵冰中，(高)冰冻2变为玄冰。", BLM.JobID)]
    BlackBlizzard2Feature = 2509,

    [CustomComboInfo("Fire 2/Ice 2 Option", "Fire 2 and Blizzard 2 will not change unless you're at max Astral Fire or Umbral Ice. 除非你处于最大星灵火或星灵冰，否则火炎2和冰冻2不会改变。", BLM.JobID)]
    BlackFireBlizzard2Option = 2514,

    [CustomComboInfo("Umbral Soul Feature", "Replace your ice spells with Umbral Soul, while in Umbral Ice and having no target. 在星灵冰中并且没有目标时，将你的冰系法术替换为灵极魂。", BLM.JobID)]
    BlackSpellsUmbralSoulFeature = 2517,

    [CustomComboInfo("Scathe/Xenoglossy Feature", "Scathe becomes Xenoglossy when available. 当异言可用时，崩溃变为异言。", BLM.JobID)]
    BlackScatheFeature = 2507,

    [CustomComboInfo("Thunder 3/4 to Sharpcast", "Thunder 3 and Thunder 4 become Sharpcast when available. 当激情咏唱可用时，霹雷3和霹雷4变为激情咏唱。", BLM.JobID)]
    BlackThunderFeature = 2519,

    [ParentCombo(BlackThunderFeature)]
    [CustomComboInfo("Delay replacement after casting Thunder", "Delay changing Thunder into Sharpcast immediately after casting Thunder. 施放闪雷后立即延迟将闪雷变为激情咏唱。", BLM.JobID)]
    BlackThunderDelayOption = 2520,

    #endregion
    // ====================================================================================
    #region BARD

    [CustomComboInfo("Heavy Shot into Straight Shot", "Replace Heavy Shot with Straight Shot/Refulgent Arrow when available. 当可用时，将强力射击替换为直线射击/辉煌箭。", BRD.JobID)]
    BardStraightShotUpgradeFeature = 2302,

    [CustomComboInfo("Iron Jaws Feature", "Replace Iron Jaws with Caustic Bite/Stormbite depending on which is not present on the target. 根据目标上哪个效果不存在，将伶牙俐齿替换为烈毒咬箭/狂风蚀箭。", BRD.JobID)]
    BardIronJawsFeature = 2308,

    [SecretCustomCombo]
    [CustomComboInfo("Pre Iron Jaws Feature", "Replace Iron Jaws with Caustic Bite/Stormbite depending on the duration when Iron Jaws is not available. 当伶牙俐齿不可用时，根据持续时间将伶牙俐齿替换为烈毒咬箭/狂风蚀箭。", BRD.JobID)]
    BardPreIronJawsFeature = 2303,

    [CustomComboInfo("Burst Shot/Quick Nock into Apex Arrow", "Replace Burst Shot and Quick Nock with Apex Arrow when gauge is full. 当能量条满时，将爆发射击和连珠箭替换为绝峰箭。", BRD.JobID)]
    BardApexFeature = 2304,

    [CustomComboInfo("Quick Nock into Shadowbite", "Replace Quick Nock with Shadowbite when available. 当可用时，将连珠箭替换为影噬箭。", BRD.JobID)]
    BardShadowbiteFeature = 2305,

    [ParentCombo(BardShadowbiteFeature)]
    [CustomComboInfo("A Barrage of Shadowbites", "Replace Quick Nock with Barrage when off cooldown and Shadowbite is available. 当纷乱箭不在冷却并且影噬箭可用时，将连珠箭替换为纷乱箭。", BRD.JobID)]
    BardShadowbiteBarrageFeature = 2321,

    [SecretCustomCombo]
    [CustomComboInfo("Perfect Bloodletter Feature", "Replace Bloodletter with Pitch Perfect when Repertoire charges are full. 当乐章充满时，将失血箭替换为完美音调。", BRD.JobID)]
    BardPerfectBloodletterFeature = 2315,

    [SecretCustomCombo]
    [CustomComboInfo("Expiring Perfect Bloodletter Feature", "Replace Bloodletter with Pitch Perfect when Wanderers Minuet has less than 2.5 seconds remaining and atleast one Repertoire charge. 当放浪神的小步舞曲剩余时间少于2.5秒并且至少有一个乐章充能时，将失血箭替换为完美音调。", BRD.JobID)]
    BardExpiringPerfectBloodletterFeature = 2316,

    [SecretCustomCombo]
    [ConflictingCombos(BardBloodRainFeature)]
    [CustomComboInfo("Bloodletter Feature", "Replace Bloodletter with Empyreal Arrow and Sidewinder depending on which is available. 根据哪个技能可用，将失血箭替换为九天连箭或侧风诱导箭。", BRD.JobID)]
    BardBloodletterFeature = 2306,

    [SecretCustomCombo]
    [CustomComboInfo("Rain of Death Feature", "Replace Rain of Death with Empyreal Arrow and Sidewinder depending on which is available. 根据哪个技能可用，将死亡箭雨替换为九天连箭或侧风诱导箭。", BRD.JobID)]
    BardRainOfDeathFeature = 2307,

    [SecretCustomCombo]
    [CustomComboInfo("Perfect Rain of Death Feature", "Replace Rain of Death with Pitch Perfect when Repertoire charges are full. 当乐章充满时，将死亡箭雨替换为完美音调。", BRD.JobID)]
    BardPerfectRainOfDeathFeature = 2318,

    [SecretCustomCombo]
    [CustomComboInfo("Expiring Perfect Rain of Death Feature", "Replace Rain of Death with Pitch Perfect when Wanderers Minuet has less than 2.5 seconds remaining and atleast one Repertoire charge. 当放浪神的小步舞曲剩余时间少于2.5秒并且至少有一个乐章充能时，将死亡箭雨替换为完美音调。", BRD.JobID)]
    BardExpiringPerfectRainOfDeathFeature = 2319,

    [SecretCustomCombo]
    [CustomComboInfo("Empyreal Arrow Feature", "Replace Empyreal Arrow with Sidewinder depending on which is available. 根据哪个技能可用，将九天连箭替换为侧风诱导箭。", BRD.JobID)]
    BardEmpyrealArrowFeature = 2320,

    [SecretCustomCombo]
    [CustomComboInfo("Sidewinder Feature", "Replace Sidewinder with Empyreal Arrow depending on which is available. 根据哪个技能可用，将侧风诱导箭替换为九天连箭。", BRD.JobID)]
    BardSidewinderFeature = 2309,

    [CustomComboInfo("Radiant Voice Feature", "Replace Radiant Finale with Battle Voice if Battle Voice is available. 当战斗之声可用时，将光明神的最终乐章替换为战斗之声。", BRD.JobID)]
    BardRadiantVoiceFeature = 2310,

    [CustomComboInfo("Radiant Strikes Feature", "Replace Radiant Finale with Raging Strikes if Raging Strikes is available.\nThis takes priority over Battle Voice if Radiant Voice is enabled. \n当猛者强击可用时，将光明神的最终乐章替换为猛者强击。\n如果启用了光明神之声效果，此效果优先于战斗之声。", BRD.JobID)]
    BardRadiantStrikesFeature = 2311,

    [CustomComboInfo("Barrage Feature", "Replace Barrage with Straight Shot if you have Straight Shot Ready (unless Shadowbite is ready). 如果你有直线射击准备好的状态（除非影噬箭准备好）", BRD.JobID)]
    BardBarrageFeature = 2312,

    [SecretCustomCombo]
    [ConflictingCombos(BardBloodletterFeature)]
    [CustomComboInfo("Bloodletter to Rain of Death", "Replace Bloodletter with Rain of Death if there are no self-applied DoTs on your target. 如果你的目标上没有你自己施加的持续伤害效果，将失血箭替换为死亡箭雨。", BRD.JobID)]
    BardBloodRainFeature = 2313,

    [CustomComboInfo("Wanderer's Minuet Semi-Fix", "Turns Peloton into Wanderer's Minuet to Pitch Perfect while you have a target, letting you use it regardless of whatever other bards are doing. 当你有目标时，将轻步替换为放浪神的小步舞曲到完美音调，让你无论其他吟游诗人如何操作都可以使用它。", BRD.JobID)]
    BardWanderersPitchPerfectFeature = 2314,

    [CustomComboInfo("Cycling Song Feature", "Replace Mage's Ballad with Wanderer's Minuet, Mage's Ballad, and Army's Paeon, while the previous is on cooldown. 当前一个歌曲在冷却时，将贤者的叙事谣替换为放浪神的小步舞曲、贤者的叙事谣和军神的赞美歌。", BRD.JobID)]
    BardCyclingSongFeature = 2317,

    #endregion
    // ====================================================================================
    #region DANCER

    [CustomComboInfo("Fan Dance 3 Feature", "Replace Fan Dance and Fan Dance 2 with Fan Dance 3 when available. 当扇舞·急可用时，将扇舞·序和扇舞·破替换为扇舞·急。", DNC.JobID)]
    DancerFanDance3Feature = 3801,

    [ParentCombo(DancerFanDance3Feature)]
    [CustomComboInfo("Fan Dance 4 Feature", "Replace Fan Dance and Fan Dance 2 with Fan Dance 4 when available. 当扇舞·终可用时，将扇舞·序和扇舞·破替换为扇舞·终。", DNC.JobID)]
    DancerFanDance4Feature = 3809,

    [SecretCustomCombo]
    [ConflictingCombos(DancerDanceComboCompatibility)]
    [CustomComboInfo("Dance Step Combo", "Replace Standard Step and Technical Step with each dance step while dancing. 在跳舞时，将标准舞步和技巧舞步替换为每个舞步。", DNC.JobID)]
    DancerDanceStepCombo = 3802,

    [CustomComboInfo("Flourishing Fan Dance 3", "Replace Flourish with Fan Dance 3 when available. 当扇舞·急可用时，将百花争艳替换为扇舞·急。", DNC.JobID)]
    DancerFlourishFan3Feature = 3810,

    [CustomComboInfo("Flourishing Fan Dance 4", "Replace Flourish with Fan Dance 4 when available. 当扇舞·终可用时，将百花争艳替换为扇舞·终。", DNC.JobID)]
    DancerFlourishFan4Feature = 3808,

    [ConflictingCombos(DancerSingleTargetProcs)]
    [CustomComboInfo("Single Target Multibutton", "Replace Cascade with its procs and combos as they activate. 当触发连击和连击效果时，将瀑泻替换为其触发效果。", DNC.JobID)]
    DancerSingleTargetMultibutton = 3804,

    [ConflictingCombos(DancerSingleTargetMultibutton)]
    [CustomComboInfo("Single Target to Procs", "Replace Cascade and Fountain with Reverse Cascade and Fountainfall respectively when available. 当逆瀑泻和坠喷泉可用时，分别将瀑泻和喷泉替换。", DNC.JobID)]
    DancerSingleTargetProcs = 3811,

    [CustomComboInfo("AoE Multibutton", "Replace Windmill with its procs and combos as they activate. 当触发连击和连击效果时，将风车替换为其触发效果。", DNC.JobID)]
    DancerAoeMultibutton = 3805,

    [CustomComboInfo("AoE to Procs", "Replace Windmill and Bladeshower with Rising Wiindmill and Bloodshower respectively when available. 当升风车和落血雨可用时，分别将风车和落刃雨替换。", DNC.JobID)]
    DancerAoeProcs = 3812,

    [ConflictingCombos(DancerDanceStepCombo)]
    [CustomComboInfo(
        "Dance Step Feature 舞步特性",
        "Replace arbitrary actions with dance steps while dancing. 在跳舞时，将任意动作替换为舞步。" +
        "\nThis helps ensure you can still dance with combos on, without using auto dance. 这有助于确保你在启用组合时仍然可以跳舞，而不使用自动跳舞。" +
        "\nYou can change the respective actions by inputting action IDs below for each dance step. 你可以通过为每个舞步输入动作ID来更改相应的动作。" +
        "\nThe defaults are Cascade, Flourish, Fan Dance and Fan Dance II. If set to 0, they will reset to these actions. 默认为瀑泻、百花争艳、扇舞和扇舞II。如果设置为0，它们将重置为这些动作。" +
        "\nYou can get Action IDs with Garland Tools by searching for the action and clicking the cog. 你可以通过Garland Tools搜索动作并点击齿轮来获取动作ID。",
        DNC.JobID)]
    DancerDanceComboCompatibility = 3806,

    [CustomComboInfo("Devilment Feature", "Replace Devilment with Starfall Dance when active. 当流星舞激活时，将进攻之探戈替换为流星舞。", DNC.JobID)]
    DancerDevilmentFeature = 3807,

    #endregion
    // ====================================================================================
    #region DARK KNIGHT

    [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain. 将噬魂斩替换为其连击链。", DRK.JobID)]
    DarkSouleaterCombo = 3201,

    [ParentCombo(DarkSouleaterCombo)]
    [CustomComboInfo("Souleater Overcap Feature", "Replace Souleater with Bloodspiller when the next combo action would cause the Blood Gauge to overcap. 当下一个连击动作会导致血量计过量时，将噬魂斩替换为血溅。", WAR.JobID)]
    DarkSouleaterOvercapFeature = 3206,

    [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain. 将刚魂替换为其连击链。", DRK.JobID)]
    DarkStalwartSoulCombo = 3202,

    [ParentCombo(DarkStalwartSoulCombo)]
    [CustomComboInfo("Stalwart Soul Overcap Feature", "Replace Stalwart Soul with Quietus when the next combo action would cause the Blood Gauge to overcap. 当下一个连击动作会导致血量计过量时，将刚魂替换为寂灭。", WAR.JobID)]
    DarkStalwartSoulOvercapFeature = 3207,

    [CustomComboInfo("Delirium Feature", "Replace Souleater and Stalwart Soul with Bloodspiller and Quietus when Delirium is active. 当血乱激活时，将噬魂斩和刚魂替换为血溅和寂灭。", DRK.JobID)]
    DarkDeliriumFeature = 3203,

    [CustomComboInfo("Blood Weapon Feature", "Replace Carve and Spit, and Abyssal Drain with Blood Weapon when available. 当可用时，将精雕怒斩和吸血深渊替换为嗜血。", DRK.JobID)]
    DarkBloodWeaponFeature = 3204,

    [CustomComboInfo("Living Shadow Feature", "Replace Quietus and Bloodspiller with Living Shadow when available. 当可用时，将寂灭和血溅替换为掠影示现。", DRK.JobID)]
    DarkLivingShadowFeature = 3205,

    [CustomComboInfo("Living Shadowbringer Feature", "Replace Living Shadow with Shadowbringer when charges are available and your Shadow is present. 当充能可用且你的暗影在场时，将掠影示现替换为暗影使者。", DRK.JobID)]
    DarkLivingShadowbringerFeature = 3208,

    [CustomComboInfo("Missing Shadowbringer Feature", "Replace Living Shadow with Shadowbringer when charges are available and Living Shadow is on cooldown. 当充能可用且掠影示现在冷却时，将掠影示现替换为暗影使者。", DRK.JobID)]
    DarkLivingShadowbringerHpFeature = 3209,

    #endregion
    // ====================================================================================
    #region DRAGOON

    [CustomComboInfo("Jump + Mirage Dive", "Replace (High) Jump with Mirage Dive when Dive Ready. 当潜行准备好时，用幻象冲替换(高)跳跃。", DRG.JobID)]
    DragoonJumpFeature = 2201,

    [CustomComboInfo("Coerthan Torment Combo", "Replace Coerthan Torment with its combo chain. 将山境酷刑替换为其连击链。", DRG.JobID)]
    DragoonCoerthanTormentCombo = 2202,

    [CustomComboInfo("Coerthan Torment Wyrmwind Feature", "Replace Coerthan Torment with Wyrmwind Thrust when you have two Firstminds' Focus. 当你拥有两个初心集中时，将山境酷刑替换为天龙点睛。", DRG.JobID)]
    DragoonCoerthanWyrmwindFeature = 2207,

    [CustomComboInfo("Chaos Thrust Combo", "Replace Chaos Thrust with its combo chain. 将樱花怒放替换为其连击链。", DRG.JobID)]
    DragoonChaosThrustCombo = 2203,

    [ParentCombo(DragoonChaosThrustCombo)]
    [CustomComboInfo("Chaos Thrust Disembowel Option", "Replace Chaos Thrust with its combo chain starting instead at Disembowel, not True Thrust, while no combo is ongoing. 当没有连击进行时，将樱花怒放替换为其连击链，但从开膛枪开始，而不是精准刺。", DRG.JobID)]
    DragoonChaosThrustComboOption = 2209,

    [CustomComboInfo("Full Thrust Combo", "Replace Full Thrust with its combo chain.将直刺替换为其连击链。", DRG.JobID)]
    DragoonFullThrustCombo = 2204,

    [ParentCombo(DragoonFullThrustCombo)]
    [CustomComboInfo("Full Thrust Vorpal Thrust Option", "Replace Full Thrust with its combo chain starting instead at Vorpal Thrust, not True Thrust, while no combo is ongoing. 当没有连击进行时，将直刺替换为其连击链，但从贯通刺开始，而不是精准刺。", DRG.JobID)]
    DragoonFullThrustComboOption = 2210,

    [CustomComboInfo("Wheeling Thrust / Fang and Claw Option", "Replace Chaos Thrust with Wheeling Thrust and Full Thrust with Fang and Claw when you have either Enhanced Fang and Claw or Wheeling Thrust. 当你拥有增强的龙牙龙爪或龙尾大回旋时，将樱花怒放替换为龙尾大回旋，将直刺替换为龙牙龙爪。", DRG.JobID)]
    DragoonFangThrustFeature = 2205,

    [ConflictingCombos(DragoonStardiverDragonfireDiveFeature)]
    [CustomComboInfo("Stardiver to Nastrond", "Replace Stardiver with Nastrond when Nastrond is off-cooldown, and Geirskogul outside of Life of the Dragon. 当死者之岸不在冷却状态，以及在红莲龙血之外的武神枪时，用死者之岸替换坠星冲。", DRG.JobID)]
    DragoonStardiverNastrondFeature = 2206,

    [ConflictingCombos(DragoonStardiverNastrondFeature)]
    [CustomComboInfo("Stardiver to Dragonfire Dive", "Replace Stardiver with Dragonfire Dive when the latter is off cooldown (and you have more than 7.5s of LotD left), or outside of Life of the Dragon. 当后者不在冷却状态（并且红莲龙血剩余时间超过7.5秒），或在红莲龙血之外时，用龙炎冲替换坠星冲。", DRG.JobID)]
    DragoonStardiverDragonfireDiveFeature = 2208,

    [SecretCustomCombo]
    [ConflictingCombos(DragoonStardiverDragonfireDiveFeature, DragoonStardiverNastrondFeature)]
    [CustomComboInfo("Dive Dive Dive!", "Replace Spineshatter Dive, Dragonfire Dive, and Stardiver with whichever is available. 用任何可用的技能替换破碎冲、龙炎冲和坠星冲。", DRG.JobID)]
    DragoonDiveFeature = 2211,

    [CustomComboInfo("Geirskogul to Wyrmwind Thrust", "Replace Geirskogul with Wyrmwind Thrust when available and Geirskogul or Nastrond are on cooldown. 当天龙点睛可用，且武神枪或死者之岸在冷却时，用天龙点睛替换武神枪。", DRG.JobID)]
    DragoonGeirskogulWyrmwindFeature = 2212,

    [CustomComboInfo("Lance Charge to Dragon Sight and Battle Litany", "Replace Lance Charge with Dragon Sight and Battle Litany when available and Lance Charge is on cooldown. 当巨龙视线和战斗连祷可用，且猛枪在冷却时，用巨龙视线和战斗连祷替换猛枪。", DRG.JobID)]
    DragoonLanceChargeFeature = 2213,

    #endregion
    // ====================================================================================
    #region GUNBREAKER

    [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain. 将迅连斩替换为其连击链。", GNB.JobID)]
    GunbreakerSolidBarrelCombo = 3701,

    [ParentCombo(GunbreakerSolidBarrelCombo)]
    [CustomComboInfo("Burst Strike Feature", "Replace Solid Barrel with Burst Strike when charges are full. 当弹药满载时，用爆发击替换迅连斩。", GNB.JobID)]
    GunbreakerBurstStrikeFeature = 3710,

    [CustomComboInfo("Gnashing Fang Continuation", "Replace Gnashing Fang with Continuation moves when appropriate. 在适当的时候，用续剑动作替换烈牙。", GNB.JobID)]
    GunbreakerGnashingFangCont = 3702,

    [CustomComboInfo("Burst Strike Continuation", "Replace Burst Strike with Continuation moves when appropriate. 在适当的时候，用续剑动作替换爆发击。", GNB.JobID)]
    GunbreakerBurstStrikeCont = 3703,

    [SecretCustomCombo]
    [CustomComboInfo("Sonic Shock Feature", "Replace Bow Shock and Sonic Break with one or the other depending on which is on cooldown. 根据哪个技能在冷却中，用音速破或弓形冲波替换其中之一。", GNB.JobID)]
    GunbreakerBowShockSonicBreakFeature = 3704,

    [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain. 将恶魔杀替换为其连击链。", GNB.JobID)]
    GunbreakerDemonSlaughterCombo = 3705,

    [ParentCombo(GunbreakerDemonSlaughterCombo)]
    [CustomComboInfo("Fated Circle Feature", "In addition to the Demon Slaughter combo, add Fated Circle when charges are full. 除了恶魔杀组合外，当弹药满载时，添加命运之环。vvv", GNB.JobID)]
    GunbreakerFatedCircleFeature = 3706,

    [CustomComboInfo("Empty Bloodfest Feature", "Replace Burst Strike and Fated Circle with Bloodfest if the powder gauge is empty. 当火药计为空时，用血壤替换爆发击和命运之环。", GNB.JobID)]
    GunbreakerEmptyBloodfestFeature = 3707,

    [SecretCustomCombo]
    [CustomComboInfo("No Mercy Bow Shock/Sonic Break Feature", "Replace No Mercy with Bow Shock, and then Sonic Break, while No Mercy is active. 当无情激活时，用弓形冲波替换无情，然后用音速破。", GNB.JobID)]
    GunbreakerNoMercyFeature = 3708,

    [CustomComboInfo("No Mercy Double Down Feature", "Replace No Mercy with Double Down while No Mercy is active, 2 cartridges are available, and Double Down is off cooldown.\nThis takes priority over the No Mercy Bow Shock/Sonic Break Feature.\n当无情激活、有2颗弹药，且倍攻不在冷却时，用倍攻替换无情。\n此特性优先于无情弓形/音速特性。", GNB.JobID)]
    GunbreakerNoMercyDoubleDownFeature = 3712,

    [ConflictingCombos(GunbreakerNoMercyFeature)]
    [CustomComboInfo("No Mercy Always Double Down Feature", "Replace No Mercy with Double Down while No Mercy is active. 当无情激活时，始终用倍攻替换无情。", GNB.JobID)]
    GunbreakerNoMercyAlwaysDoubleDownFeature = 3713,

    [SecretCustomCombo]
    [CustomComboInfo("Double Down Feature", "Replace Burst Strike and Fated Circle with Double Down when available. 当倍攻可用时，用倍攻替换爆发击和命运之环。", GNB.JobID)]
    GunbreakerDoubleDownFeature = 3709,

    #endregion
    // ====================================================================================
    #region MACHINIST

    [CustomComboInfo("(Heated) Shot Combo", "Replace Clean Shot with its combo chain. 将热狙击弹替换为其连击链。", MCH.JobID)]
    MachinistMainCombo = 3101,

    [ParentCombo(MachinistMainCombo)]
    [CustomComboInfo("Hypercharge Combo", "Replace Clean Shot combo with Heat Blast while overheated. 当过热时，将热狙击弹连击替换为热冲击。", MCH.JobID)]
    MachinistHypercomboFeature = 3108,

    [CustomComboInfo("Spread Shot Heat", "Replace Spread Shot with Auto Crossbow when overheated. 当过热时，将散射替换为自动弩。", MCH.JobID)]
    MachinistSpreadShotFeature = 3102,

    [CustomComboInfo("Hypercharge Feature", "Replace Heat Blast and Auto Crossbow with Hypercharge when not overheated. 当未过热时，将热冲击和自动弩替换为超荷。", MCH.JobID)]
    MachinistOverheatFeature = 3103,

    [CustomComboInfo("Hyperfire Feature", "Replace Hypercharge with Wildfire if available and you have a target. 如果可用并且有目标，将超荷替换为野火。", MCH.JobID)]
    MachinistHyperfireFeature = 3109,

    [CustomComboInfo("Overdrive Feature", "Replace Rook Autoturret and Automaton Queen with Overdrive while active. 当车式浮空炮塔和后式自走人偶激活时，用超档替换它们。", MCH.JobID)]
    MachinistOverdriveFeature = 3104,

    [SecretCustomCombo]
    [CustomComboInfo("Gauss Round / Ricochet Feature", "Replace Gauss Round and Ricochet with one or the other depending on which has more charges. 根据哪个技能有更多次数，用虹吸弹或弹射替换其中之一。", MCH.JobID)]
    MachinistGaussRoundRicochetFeature = 3105,

    [SecretCustomCombo]
    [ParentCombo(MachinistGaussRoundRicochetFeature)]
    [CustomComboInfo("Gauss Round / Ricochet Overheat Option", "Replace Gauss Round and Ricochet with one or the other only while overheated. 仅在过热时，用虹吸弹或弹射替换其中之一。", MCH.JobID)]
    MachinistGaussRoundRicochetFeatureOption = 3110,

    [SecretCustomCombo]
    [ConflictingCombos(MachinistHotShotChainsawFeature)]
    [CustomComboInfo("Hot Shot (Air Anchor) / Drill / Chainsaw Feature", "Replace Hot Shot (Air Anchor), Drill, and Chainsaw with whichever is available. 用可用的热弹(空气锚)、钻头或飞锯替换其中之一。", MCH.JobID)]
    MachinistHotShotDrillChainsawFeature = 3106,

    [SecretCustomCombo]
    [ConflictingCombos(MachinistHotShotDrillChainsawFeature)]
    [CustomComboInfo("Hot Shot (Air Anchor) / Chainsaw Feature", "Replace Hot Shot (Air Anchor) and Chainsaw with whichever is available. 用可用的热弹(空气锚)或飞锯替换其中之一。", MCH.JobID)]
    MachinistHotShotChainsawFeature = 3107,

    [SecretCustomCombo]
    [CustomComboInfo("Bioblaster / Chainsaw Feature", "Replace Bioblaster with whichever of Bioblaster or Chainsaw is available. 用可用的毒菌冲击或飞锯替换毒菌冲击。", MCH.JobID)]
    MachinistBioblasterChainsawFeature = 3111,

    #endregion
    // ====================================================================================
    #region MONK

    [CustomComboInfo("Monk AoE Combo", "Replace Masterful Blitz with the AoE combo chain. This was changed from Rockbreaker due to an action queueing bug. 将必杀技替换为AoE连击链。由于动作排队错误，这从地烈劲更改。", MNK.JobID)]
    MonkAoECombo = 2001,

    [CustomComboInfo("Dragon Kick / Bootshine Feature", "Replace Dragon Kick with Bootshine if Leaden Fist is up. 如果铁拳效果存在，将双龙脚替换为连击。", MNK.JobID)]
    MonkBootshineFeature = 2011,

    [ConflictingCombos(MonkTrueStrikeFeature)]
    [CustomComboInfo("Twin Snakes / True Strike Feature", "Replace Twin Snakes with True Strike if Twin Snakes has more than 6s remaining. 如果双掌打的剩余时间超过6秒，将其替换为正拳。", MNK.JobID)]
    MonkTwinSnakesFeature = 2013,

    [ParentCombo(MonkTwinSnakesFeature)]
    [CustomComboInfo("Formless Snakes Option", "While Formless Fist is active, do not replace Twin Snakes. 当无形拳激活时，不替换双掌打。", MNK.JobID)]
    MonkFormlessSnakesOption = 2015,

    [ConflictingCombos(MonkTwinSnakesFeature)]
    [CustomComboInfo("True Strike / Twin Snakes Feature", "Replace True Strike with Twin Snakes if Twin Snakes has less than 6s remaining. 如果双掌打的剩余时间少于6秒，将正拳替换为双掌打。", MNK.JobID)]
    MonkTrueStrikeFeature = 2016,

    [CustomComboInfo("Demolish / Snap Punch Feature", "Replace Demolish with Snap Punch if Demolish has more than 6s remaining on your current target. 如果当前目标上的破碎拳的剩余时间超过6秒，将其替换为崩拳。", MNK.JobID)]
    MonkDemolishFeature = 2014,

    [CustomComboInfo("Dragon Balance Feature", "Replace Dragon Kick with Masterful Blitz if you have 3 Beast Chakra. 当你有3兽斗气时，将双龙脚替换为必杀技。", MNK.JobID)]
    MonkDragonKickBalanceFeature = 2005,

    [CustomComboInfo("Dragon Meditation Feature", "Replace Dragon Kick with Meditation when out of combat and the Fifth Chakra is not open. 当不在战斗中且第五斗气未开启时，将双龙脚替换为斗气。", MNK.JobID)]
    MonkDragonKickMeditationFeature = 2012,

    [CustomComboInfo("Howling Fist / Meditation Feature", "Replace Howling Fist with Meditation when the Fifth Chakra is not open. 当第五斗气未开启时，将空鸣拳替换为斗气。", MNK.JobID)]
    MonkHowlingFistMeditationFeature = 2003,

    [CustomComboInfo("Perfect Balance Feature", "Replace Perfect Balance with Masterful Blitz when you have 3 Beast Chakra. 当你有3兽斗气时，将震脚替换为必杀技。", MNK.JobID)]
    MonkPerfectBalanceFeature = 2004,

    [CustomComboInfo("Riddle of Brotherly Fire", "Replace Riddle of Fire with Brotherhood when on cooldown. 当红莲极意冷却时，替换为义结金兰。", MNK.JobID)]
    MonkRiddleOfFireBrotherhood = 2009,

    [CustomComboInfo("Riddle of Fire and Wind", "Replace Riddle of Fire with Riddle of Wind when on cooldown. 当红莲极意冷却时，替换为疾风极意。", MNK.JobID)]
    MonkRiddleOfFireWind = 2010,

    #endregion
    // ====================================================================================
    #region NINJA

    [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain. 将旋风刃替换为其连击链。", NIN.JobID)]
    NinjaAeolianEdgeCombo = 3002,

    [SecretCustomCombo]
    [CustomComboInfo("Aeolian Edge / Huton Feature", "Replaces Aeolian Edge with Armor Crush when Huton has less than 30 seconds remaining and Huraijin when missing. 当风遁剩余时间少于30秒时，将旋风刃替换为强甲破点突；当风遁效果缺失时，替换为风来刃。", NIN.JobID)]
    NinjaAeolianEdgeHutonFeature = 3019,

    [CustomComboInfo("Aeolian Edge / Ninjutsu Feature", "Replace Aeolian Edge with Ninjutsu if any Mudra are used. 如果使用了任何印记，将旋风刃替换为忍术。", NIN.JobID)]
    NinjaAeolianNinjutsuFeature = 3008,

    [CustomComboInfo("Aeolian Edge / Raiju Feature", "Replace the Aeolian Edge combo with Fleeting Raiju when available. 当可用时，将旋风刃连击替换为飞雷兽牙。", NIN.JobID)]
    NinjaAeolianEdgeRaijuFeature = 3013,

    [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain. 将强甲破点突替换为其连击链。", NIN.JobID)]
    NinjaArmorCrushCombo = 3001,

    [CustomComboInfo("Armor Crush / Ninjutsu Feature", "Replace Armor Crush with Ninjutsu if any Mudra are used. 如果使用了任何印记，将强甲破点突替换为忍术。", NIN.JobID)]
    NinjaArmorCrushNinjutsuFeature = 3015,

    [CustomComboInfo("Armor Crush / Raiju Feature", "Replace the Armor Crush combo with Forked Raiju when available. 当可用时，将强甲破点突连击替换为分雷兽爪。", NIN.JobID)]
    NinjaArmorCrushRaijuFeature = 3012,

    [CustomComboInfo("Huraijin / Armor Crush Combo", "Replace Huraijin with Armor Crush after using Gust Slash when Huton is missing. 在使用绝风后，如果风遁效果缺失，将风来刃替换为强甲破点突。", NIN.JobID)]
    NinjaHuraijinArmorCrushCombo = 3010,

    [CustomComboInfo("Huraijin / Ninjutsu Feature", "Replace Huraijin with Ninjutsu if any Mudra are used. 如果使用了任何印记，将风来刃替换为忍术。", NIN.JobID)]
    NinjaHuraijinNinjutsuFeature = 3009,

    [ConflictingCombos(NinjaHuraijinFleetingRaijuFeature)]
    [CustomComboInfo("Huraijin / Forked Raiju Feature", "Replace Huraijin with Forked Raiju when available. 当可用时，将风来刃替换为分雷兽爪。", NIN.JobID)]
    NinjaHuraijinForkedRaijuFeature = 3011,

    [ConflictingCombos(NinjaHuraijinForkedRaijuFeature)]
    [CustomComboInfo("Huraijin / Fleeting Raiju Option", "Replace Huraijin with Fleeting Raiju when available. 当可用时，将风来刃替换为飞雷兽牙。", NIN.JobID)]
    NinjaHuraijinFleetingRaijuFeature = 3014,

    [CustomComboInfo("Hakke Mujinsatsu Combo", "Replace Hakke Mujinsatsu with its combo chain. 将八卦无刃杀替换为其连击链。", NIN.JobID)]
    NinjaHakkeMujinsatsuCombo = 3003,

    [CustomComboInfo("Hakke Mujinsatsu / Ninjutsu Feature", "Replace Hakke Mujinsatsu with Ninjutsu if any Mudra are used. 如果使用了任何印记，将八卦无刃杀替换为忍术。", NIN.JobID)]
    NinjaHakkeMujinsatsuNinjutsuFeature = 3016,

    [ConflictingCombos(NinjaNinjitsuFleetingRaijuFeature)]
    [CustomComboInfo("Ninjitsu / Forked Raiju Feature", "Replace Ninjitsu with Forked Raiju when available and no Mudra are active. 当分雷兽爪可用且没有印记激活时，替换忍术为分雷兽爪。", NIN.JobID)]
    NinjaNinjitsuForkedRaijuFeature = 3017,

    [ConflictingCombos(NinjaNinjitsuForkedRaijuFeature)]
    [CustomComboInfo("Ninjitsu / Fleeting Raiju Feature", "Replace Ninjitsu with Fleeting Raiju when available and no Mudra are active. 当飞雷兽牙可用且没有印记激活时，替换忍术为飞雷兽牙。", NIN.JobID)]
    NinjaNinjitsuFleetingRaijuFeature = 3018,

    [CustomComboInfo("Kassatsu to Trick", "Replace Kassatsu with Trick Attack while Suiton or Hidden is up.\nCooldown tracking plugin recommended.\n当水遁或隐遁效果存在时，将生杀予夺替换为攻其不备。\n建议使用冷却追踪插件。", NIN.JobID)]
    NinjaKassatsuTrickFeature = 3004,

    [CustomComboInfo("Ten Chi Jin to Meisui", "Replace Ten Chi Jin (the move) with Meisui while Suiton is up.\nCooldown tracking plugin recommended.\n当水遁效果存在时，将天地人替换为命水。\n建议使用冷却追踪插件。", NIN.JobID)]
    NinjaTCJMeisuiFeature = 3005,

    [CustomComboInfo("Kassatsu Chi/Jin Feature", "Replace Chi with Jin while Kassatsu is up if you have Enhanced Kassatsu. 当生杀予夺激活且拥有生杀予夺效果提高时，将地之印替换为人之印。", NIN.JobID)]
    NinjaKassatsuChiJinFeature = 3006,

    [CustomComboInfo("Hide to Mug", "Replace Hide with Mug while in combat. 在战斗中将隐遁替换为夺取。", NIN.JobID)]
    NinjaHideMugFeature = 3007,

    [CustomComboInfo("Hide to Ninjutsu", "Replace Hide with Ninjutsu if any Mudra are active. 当任何印记激活时，将隐遁替换为忍术。", NIN.JobID)]
    NinjaHideNinjutsuFeature = 3020,

    #endregion
    // ====================================================================================
    #region PALADIN

    [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority with its combo chain. 将王权剑替换为其连击链。", PLD.JobID)]
    PaladinRoyalAuthorityCombo = 1902,

    [ParentCombo(PaladinRoyalAuthorityCombo)]
    [CustomComboInfo("Royal Authority Divine Might Feature", "Replace Royal Authority with Holy Spirit when Divine Might would overcap. 当神圣力量可能超量时，将王权剑替换为圣灵。", PLD.JobID)]
    PaladinRoyalAuthorityDivineMightFeature = 1912,

    [ParentCombo(PaladinRoyalAuthorityCombo)]
    [CustomComboInfo("Royal Authority Fight or Flight Feature", "Replace Royal Authority with Holy Spirit during Fight or Flight when Divine Might is active. 在战逃反应期间，当神圣力量激活时，将王权剑替换为圣灵。", PLD.JobID)]
    PaladinRoyalAuthorityFightOrFlightFeature = 1915,

    [ParentCombo(PaladinRoyalAuthorityCombo)]
    [CustomComboInfo("Royal Authority Atonement Feature", "Replace Royal Authority with Atonement when under the effect of Sword Oath. 在忠义之剑效果下，将王权剑替换为赎罪剑。", PLD.JobID)]
    PaladinRoyalAuthorityAtonementFeature = 1903,

    [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain. 将日珥斩替换为其连击链。", PLD.JobID)]
    PaladinProminenceCombo = 1904,

    [ParentCombo(PaladinProminenceCombo)]
    [CustomComboInfo("Prominence Divine Might Feature", "Replace Prominence with Holy Circle when Divine Might is active. 当神圣力量激活时，将日珥斩替换为圣环。", PLD.JobID)]
    PaladinProminenceDivineMightFeature = 1913,

    [CustomComboInfo("Requiescat Fight or Flight Feature", "Replace Requiescat with Fight or Flight when off cooldown or if it will be ready sooner. 当安魂祈祷冷却结束或即将结束时，将其替换为战逃反应。", PLD.JobID)]
    PaladinRequiescatFightOrFlightFeature = 1914,

    [CustomComboInfo("Requiescat Confiteor", "Replace Requiescat with Confiteor and combo chain while under the effect of Requiescat, and then with Holy Spirit if there are remaining charges. 在安魂祈祷效果下，先替换为悔罪及其连击链，然后如果还有剩余次数，替换为圣灵。", PLD.JobID)]
    PaladinRequiescatCombo = 1905,

    [CustomComboInfo("Fight or Flight Goring Blade Feature", "Replace Fight or Flight with Goring Blade while Fight or Flight is active.  Also applies to Requiescat if the Requiescat Fight or Flight Feature is enabled. 在战逃反应激活时，将战逃反应替换为沥血剑。如果启用了安魂祈祷战逃反应特性，也适用于安魂祈祷。", PLD.JobID)]
    PaladinFightOrFlightGoringBladeFeature = 1911,

    [CustomComboInfo("Confiteor Feature", "Replace Holy Spirit/Circle with Confiteor while under the effect of Requiescat. 在安魂祈祷效果下，将圣灵/圣环替换为悔罪。", PLD.JobID)]
    PaladinConfiteorFeature = 1907,

    [SecretCustomCombo]
    [CustomComboInfo("Scornful Spirits Feature", "Replace Spirits Within/Expiacion and Circle of Scorn with whichever is available soonest. 将深奥之灵/偿赎剑和厄运流转替换为最快可用的技能。", PLD.JobID)]
    PaladinScornfulSpiritsFeature = 1908,

    [CustomComboInfo("Shields on your Feet Feature", "Replace Shield Bash with Low Blow when available. 当技能可用时，将盾牌猛击替换为低劣打击。", PLD.JobID)]
    PaladinShieldBashFeature = 1910,

    #endregion
    // ====================================================================================
    #region REAPER

    [CustomComboInfo("Slice Combo", "Replace Infernal Slice with its combo chain. 将地狱切割替换为其连击链。", RPR.JobID)]
    ReaperSliceCombo = 3901,

    [ConflictingCombos(ReaperSliceGallowsFeature)]
    [CustomComboInfo("Slice Gibbet Feature", "Replace Infernal Slice with Gibbet while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将地狱切割替换为绞决。", RPR.JobID)]
    ReaperSliceGibbetFeature = 3903,

    [ConflictingCombos(ReaperSliceGibbetFeature)]
    [CustomComboInfo("Slice Gallows Feature", "Replace Infernal Slice with Gallows while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将地狱切割替换为缢杀。", RPR.JobID)]
    ReaperSliceGallowsFeature = 3904,

    [CustomComboInfo("Slice Enhanced Soul Reaver Feature", "Replace Infernal Slice with whichever of Gibbet or Gallows is currently enhanced while Reaving. 在收割状态下，将地狱切割替换为当前增强的绞决或缢杀。", RPR.JobID)]
    ReaperSliceEnhancedSoulReaverFeature = 3913,

    [CustomComboInfo("Slice Enhanced Enshrouded Feature", "Replace Infernal Slice with whichever of Gibbet or Gallows is currently enhanced while Enshrouded. 在夜游魂衣状态下，将地狱切割替换为当前增强的绞决或缢杀。", RPR.JobID)]
    ReaperSliceEnhancedEnshroudedFeature = 3914,

    [CustomComboInfo("Slice Lemure's Feature", "Replace Infernal Slice with Lemure's Slice when two or more stacks of Void Shroud are active. 当两个或更多的虚无魂衣堆叠激活时，将地狱切割替换为夜游魂切割。", RPR.JobID)]
    ReaperSliceLemuresFeature = 3919,

    [CustomComboInfo("Slice Communio Feature", "Replace Infernal Slice with Communio when one stack of Shroud is left. 当魂衣剩余一个堆叠时，将地狱切割替换为团契。", RPR.JobID)]
    ReaperSliceCommunioFeature = 3920,

    [CustomComboInfo("Slice Soulsow Feature", "Replace Infernal Slice with Soulsow when out of combat and not active. 在非战斗状态且未激活时，将地狱切割替换为播魂种。", RPR.JobID)]
    ReaperSliceSoulsowFeature = 3930,

    [ConflictingCombos(ReaperShadowGibbetFeature)]
    [CustomComboInfo("Shadow Gallows Feature", "Replace Shadow of Death with Gallows while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将死亡之影替换为缢杀。", RPR.JobID)]
    ReaperShadowGallowsFeature = 3905,

    [ConflictingCombos(ReaperShadowGallowsFeature)]
    [CustomComboInfo("Shadow Gibbet Feature", "Replace Shadow of Death with Gibbet while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将死亡之影替换为绞决。", RPR.JobID)]
    ReaperShadowGibbetFeature = 3906,

    [CustomComboInfo("Shadow Lemure's Feature", "Replace Shadow of Death with Lemure's Slice when two or more stacks of Void Shroud are active. 当两个或更多的虚无魂衣堆叠激活时，将死亡之影替换为夜游魂切割。", RPR.JobID)]
    ReaperShadowLemuresFeature = 3923,

    [CustomComboInfo("Shadow Communio Feature", "Replace Shadow of Death with Communio when one stack of Shroud is left. 当魂衣剩余一个堆叠时，将死亡之影替换为团契。", RPR.JobID)]
    ReaperShadowCommunioFeature = 3924,

    [CustomComboInfo("Shadow Soulsow Feature", "Replace Shadow of Death with Soulsow when out of combat, not active, and you have no target. 在非战斗状态、未激活且没有目标时，将死亡之影替换为播魂种。", RPR.JobID)]
    ReaperShadowSoulsowFeature = 3929,

    [ConflictingCombos(ReaperSoulGibbetFeature)]
    [CustomComboInfo("Soul Gallows Feature", "Replace Soul Slice with Gallows while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将灵魂切割替换为缢杀。", RPR.JobID)]
    ReaperSoulGallowsFeature = 3925,

    [ConflictingCombos(ReaperSoulGallowsFeature)]
    [CustomComboInfo("Soul Gibbet Feature", "Replace Soul Slice with Gibbet while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将灵魂切割替换为绞决。", RPR.JobID)]
    ReaperSoulGibbetFeature = 3926,

    [CustomComboInfo("Soul Lemure's Feature", "Replace Soul Slice with Lemure's Slice when two or more stacks of Void Shroud are active. 当有两个或更多的虚无魂衣激活时，将灵魂切割替换为夜游魂切割。", RPR.JobID)]
    ReaperSoulLemuresFeature = 3927,

    [CustomComboInfo("Soul Communio Feature", "Replace Soul Slice with Communio when one stack of Shroud is left. 当魂衣剩余一个时，将灵魂切割替换为团契。", RPR.JobID)]
    ReaperSoulCommunioFeature = 3928,

    [CustomComboInfo("Soul Overcap Feature", "Replace Soul Slice with Blood Stalk not Enshrouded and greater-than 50 Soul Gauge is present. 当没有进入夜游魂衣状态且灵魂计量大于50时，将灵魂切割替换为隐匿挥割。", RPR.JobID)]
    ReaperSoulOvercapFeature = 3934,

    [CustomComboInfo("Soul (Scythe) Overcap Feature", "Replace Soul Scythe with Grim Swathe when not Enshrouded and greater-than 50 Soul Gauge is present. 当没有进入夜游魂衣状态且灵魂计量大于50时，将灵魂钐割替换为束缚挥割。", RPR.JobID)]
    ReaperSoulScytheOvercapFeature = 3935,

    [CustomComboInfo("Scythe Combo", "Replace Nightmare Scythe with its combo chain. 将噩梦钐割替换为其连击链。", RPR.JobID)]
    ReaperScytheCombo = 3902,

    [CustomComboInfo("Scythe Guillotine Feature", "Replace Nightmare Scythe with Guillotine while Reaving or Enshrouded. 在收割或夜游魂衣状态下，将噩梦钐割替换为断首。", RPR.JobID)]
    ReaperScytheGuillotineFeature = 3907,

    [CustomComboInfo("Scythe Lemure's Feature", "Replace Nightmare Scythe with Lemure's Scythe when two or more stacks of Void Shroud are active. 当有两个或更多的虚无魂衣激活时，将噩梦钐割替换为夜游魂钐割。", RPR.JobID)]
    ReaperScytheLemuresFeature = 3921,

    [CustomComboInfo("Scythe Communio Feature", "Replace Nightmare Scythe with Communio when one stack is left of Shroud. 当魂衣剩余一个时，将噩梦钐割替换为团契。", RPR.JobID)]
    ReaperScytheCommunioFeature = 3922,

    [CustomComboInfo("Scythe Soulsow Feature", "Replace Nightmare Scythe with Soulsow when out of combat and not active. 当不在战斗中且播魂种未激活时，将噩梦钐割替换为播魂种。", RPR.JobID)]
    ReaperScytheSoulsowFeature = 3931,

    [CustomComboInfo("Scythe Harvest Moon Feature", "Replace Nightmare Scythe with Harvest Moon when Soulsow is active and you have a target. 当播魂种激活且有目标时，将噩梦钐割替换为收获月。", RPR.JobID)]
    ReaperScytheHarvestMoonFeature = 3932,

    [CustomComboInfo("Enhanced Soul Reaver Feature", "Replace Gibbet and Gallows with whichever is currently enhanced while Reaving. 在收割状态下，将绞决和缢杀替换为当前增强的技能。", RPR.JobID)]
    ReaperEnhancedSoulReaverFeature = 3917,

    [CustomComboInfo("Enhanced Enshrouded Feature", "Replace Gibbet and Gallows with whichever is currently enhanced while Enshrouded. 在夜游魂衣状态下，将绞决和缢杀替换为当前增强的技能。", RPR.JobID)]
    ReaperEnhancedEnshroudedFeature = 3918,

    [CustomComboInfo("Lemure's Soul Reaver Feature", "Replace Gibbet, Gallows, and Guillotine with Lemure's Slice or Scythe when two or more stacks of Void Shroud are active.  当有两个或更多的虚无魂衣激活时，将绞决、缢杀和断首替换为夜游魂切割或钐割。", RPR.JobID)]
    ReaperLemuresSoulReaverFeature = 3911,

    [CustomComboInfo("Communio Soul Reaver Feature", "Replace Gibbet, Gallows, and Guillotine with Communio when one stack is left of Shroud. 当魂衣剩余一个时，将绞决、缢杀和断首替换为团契。", RPR.JobID)]
    ReaperCommunioSoulReaverFeature = 3912,

    [CustomComboInfo("Enshroud Communio Feature", "Replace Enshroud with Communio when Enshrouded. 在夜游魂衣状态下，将夜游魂衣替换为团契。", RPR.JobID)]
    ReaperEnshroudCommunioFeature = 3909,

    [CustomComboInfo("Blood Stalk Gluttony Feature", "Replace Blood Stalk with Gluttony when available and greater-than-or-equal-to 50 Soul Gauge is present. 当技能可用且灵魂计量大于或等于50时，将隐匿挥割替换为暴食。", RPR.JobID)]
    ReaperBloodStalkGluttonyFeature = 3915,

    [CustomComboInfo("Grim Swathe Gluttony Feature", "Replace Grim Swathe with Gluttony when available and greater-than-or-equal-to 50 Soul Gauge is present. 当灵魂计量大于或等于50时，将束缚挥割替换为暴食。", RPR.JobID)]
    ReaperGrimSwatheGluttonyFeature = 3916,

    [CustomComboInfo("Arcane Harvest Feature", "Replace Arcane Circle with Plentiful Harvest when you have stacks of Immortal Sacrifice. 当你拥有不朽牺牲层数时，将神秘环替换为大丰收。", RPR.JobID)]
    ReaperHarvestFeature = 3908,

    [CustomComboInfo("Regress Feature", "Replace Hell's Ingress and Egress turn with Regress when Threshold is active, instead of just the opposite of the one used. 当阈值激活时，将地狱入境和地狱出境替换为回退，而不仅仅是替换为相反的技能。", RPR.JobID)]
    ReaperRegressFeature = 3910,

    [ParentCombo(ReaperRegressFeature)]
    [CustomComboInfo("Delayed Regress Option", "Replace the action used with Regress only after 1.5 seconds have elapsed on Threshold. 在阈值上经过1.5秒后，才用回退替换所使用的动作。", RPR.JobID)]
    ReaperRegressOption = 3933,

    [CustomComboInfo("Harpe Soulsow Feature", "Replace Harpe with Soulsow when not active and out of combat or you have no target. 当未激活且战斗外或没有目标时，将勾刃替换为播魂种。", RPR.JobID)]
    ReaperHarpeHarvestSoulsowFeature = 3936,

    [CustomComboInfo("Harpe Harvest Moon Feature", "Replace Harpe with Harvest Moon when Soulsow is active and you are in combat. 当播魂种激活且你处于战斗中时，将勾刃替换为收获月。", RPR.JobID)]
    ReaperHarpeHarvestMoonFeature = 3937,

    [ParentCombo(ReaperHarpeHarvestMoonFeature)]
    [CustomComboInfo("Enhanced Harpe Option", "Prevent replacing Harpe with Harvest Moon when Enhanced Harpe is active. 当强化勾刃激活时，阻止将勾刃替换为收获月。", RPR.JobID)]
    ReaperHarpeHarvestMoonEnhancedFeature = 3939,

    [ParentCombo(ReaperHarpeHarvestMoonFeature)]
    [CustomComboInfo("Combat Option", "Prevent replacing Harpe with Harvest Moon when not in combat. 当不在战斗中时，阻止将勾刃替换为收获月。", RPR.JobID)]
    ReaperHarpeHarvestMoonCombatFeature = 3938,

    #endregion
    // ====================================================================================
    #region RED MAGE

    [CustomComboInfo("Verstone/Verfire Feature", "Replace Verstone/Verfire with Jolt/Scorch when no proc is available. 当没有触发效果时，将赤飞石/赤火炎替换为摇荡/焦热。", RDM.JobID)]
    RedMageVerprocFeature = 3504,

    [CustomComboInfo("Verstone/Verfire Plus Feature", "Replace Verstone/Verfire with Veraero/Verthunder when various instant-cast effects are active. 当各种即时咏唱效果激活时，将赤飞石/赤火炎替换为赤疾风/赤闪雷。", RDM.JobID)]
    RedMageVerprocPlusFeature = 3505,

    [CustomComboInfo("Verstone/Verfire Plus Opener Feature (Stone)", "Replace Verstone with Veraero when out of combat. 在战斗外时，将赤飞石替换为赤疾风。", RDM.JobID)]
    RedMageVerprocOpenerStoneFeature = 3506,

    [CustomComboInfo("Verstone/Verfire Plus Opener Feature (Fire)", "Replace Verfire with Verthunder when out of combat. 在战斗外时，将赤火炎替换为赤闪雷。", RDM.JobID)]
    RedMageVerprocOpenerFireFeature = 3507,

    [CustomComboInfo("Verstone/Verfire Mana Stacks Feature", "Replace Verstone/Verfire with Verflare/Verholy at 3 mana stacks. 当魔元堆叠为3时，将赤飞石/赤火炎替换为赤暴雷/赤神圣。", RDM.JobID)]
    RedMageVerprocManaStacksFeature = 3515,

    [CustomComboInfo("Verstone/Verfire Capstone Combo", "Replace Verstone/Verfire with Scorch and Resolution when available. 当可用时，将赤飞石/赤火炎替换为焦热和决断。", RDM.JobID)]
    RedMageVerprocCapstoneCombo = 3513,

    [CustomComboInfo("Veraero/Verthunder Capstone Combo", "Replace Veraero/Verthunder with Scorch and Resolution when available. 当可用时，将赤疾风/赤闪雷替换为焦热和决断。", RDM.JobID)]
    RedMageVeraeroVerthunderCapstoneCombo = 3512,

    [CustomComboInfo("AoE Combo", "Replace Veraero/Verthunder 2 with Impact when various instant-cast effects are active. 当各种即时咏唱效果激活时，将赤烈风/赤震雷替换为冲击。", RDM.JobID)]
    RedMageAoEFeature = 3501,

    [CustomComboInfo("AoE Capstone Combo", "Replace Veraero/Verthunder 2 with Scorch and Resolution when available. 当可用时，将赤烈风/赤震雷替换为焦热和决断。", RDM.JobID)]
    RedMageAoECapstoneCombo = 3514,

    [CustomComboInfo("Melee combo", "Replace Redoublement with its combo chain, following enchantment rules. 将魔连攻替换为其连击链，遵循魔法剑的规则。", RDM.JobID)]
    RedMageMeleeCombo = 3502,

    [CustomComboInfo("Melee Mana Stacks Feature", "Replace Redoublement and Moulinet with Verflare/Verholy at 3 mana stacks, using whichever mana color is lower. 当魔元堆叠为3时，使用魔元较低的颜色，将魔连攻和魔划圆斩替换为赤暴雷/赤神圣。", RDM.JobID)]
    RedMageMeleeManaStacksFeature = 3516,

    [CustomComboInfo("Melee Capstone Combo", "Replace Redoublement and Moulinet with Scorch and Resolution when available. 当可用时，将魔连攻和魔划圆斩替换为焦热和决断。", RDM.JobID)]
    RedMageMeleeCapstoneCombo = 3503,

    [CustomComboInfo("Acceleration into Swiftcast", "Replace Acceleration with Swiftcast when on cooldown or synced. 当促进在冷却或同步时，替换为即时咏唱。", RDM.JobID)]
    RedMageAccelerationSwiftcastFeature = 3509,

    [ParentCombo(RedMageAccelerationSwiftcastFeature)]
    [CustomComboInfo("Acceleration with Swiftcast first", "Replace Acceleration with Swiftcast when neither are on cooldown. 当促进和即时咏唱都不在冷却时，替换促进为即时咏唱。", RDM.JobID)]
    RedMageAccelerationSwiftcastOption = 3511,

    [CustomComboInfo("Embolden to Manaification", "Replace Embolden with Manafication if the former is on cooldown and the latter is not. 当鼓励在冷却且魔元化不在冷却时，替换鼓励为魔元化。", RDM.JobID)]
    RedMageEmboldenFeature = 3510,

    [SecretCustomCombo]
    [CustomComboInfo("Contre Sixte / Fleche Feature", "Replace Contre Sixte and Fleche with whichever is available. 将六分反击和飞刺替换为最快可用的技能。", RDM.JobID)]
    RedMageContreFlecheFeature = 3508,

    #endregion
    // ====================================================================================
    #region SAGE

    [CustomComboInfo("Dosis Kardia Feature", "Replace Dosis with Kardia when missing Kardion. 当缺少心关时，将注药替换为心关。", SGE.JobID)]
    SageDosisKardiaFeature = 4010,

    [CustomComboInfo("Druochole into Rhizomata Feature", "Replace Druochole with Rhizomata when Addersgall is empty. 当蛇胆为空时，将灵橡清汁替换为根素。", SGE.JobID)]
    SageDruocholeRhizomataFeature = 4003,

    [CustomComboInfo("Druochole into Taurochole Feature", "Replace Druochole with Taurochole when off cooldown.\nWarning: This will limit your abiility to use Druochole.\n当技能冷却结束时，将灵橡清汁替换为白牛清汁。\n警告：这将限制你使用灵橡清汁的能力。", SGE.JobID)]
    SageDruocholeTaurocholeFeature = 4009,

    [CustomComboInfo("Ixochole into Rhizomata Feature", "Replace Ixochole with Rhizomata when Addersgall is empty. 当蛇胆为空时，将寄生清汁替换为根素。", SGE.JobID)]
    SageIxocholeRhizomataFeature = 4004,

    [CustomComboInfo("Kerachole into Rhizomata Feature", "Replace Kerachole with Rhizomata when Addersgall is empty. 当蛇胆为空时，将坚角清汁替换为根素。", SGE.JobID)]
    SageKeracholaRhizomataFeature = 4005,

    [CustomComboInfo("Phlegma into Dyskrasia", "Replace Phlegma with Dyskrasia when no charges remain or have no target. 当没有剩余次数或没有目标时，将发炎替换为失衡。", SGE.JobID)]
    SagePhlegmaDyskrasia = 4008,

    [CustomComboInfo("Phlegma into Toxikon", "Replace Phlegma with Toxikon when no charges rmemain and have Addersting.\nThis takes priority over Phlegma into Dyskrasia.\n当没有剩余次数且拥有蛇刺时，将发炎替换为箭毒。\n此设置优先于发炎转失衡。", SGE.JobID)]
    SagePhlegmaToxicon = 4007,

    [CustomComboInfo("Soteria Kardia Feature", "Replace Soteria with Kardia when off cooldown and missing Kardion. 当技能冷却结束且缺少心关时，将拯救替换为心关。", SGE.JobID)]
    SageSoteriaKardionFeature = 4006,

    [CustomComboInfo("Taurochole into Druochole Feature", "Replace Taurochole with Druochole when on cooldown 当技能冷却时，将白牛清汁替换为灵橡清汁。", SGE.JobID)]
    SageTaurocholeDruocholeFeature = 4001,

    [CustomComboInfo("Taurochole into Rhizomata Feature", "Replace Taurochole with Rhizomata when Addersgall is empty. 当蛇胆为空时，将白牛清汁替换为根素。", SGE.JobID)]
    SageTaurocholeRhizomataFeature = 4002,

    [CustomComboInfo("Toxikon into Phlegma Feature", "Replace Toxikon with Phlegma when charges are available. 当有可用次数时，将箭毒替换为发炎。", SGE.JobID)]
    SageToxikonPhlegma = 4011,

    #endregion
    // ====================================================================================
    #region SAMURAI

    [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain. 将雪风替换为其连击链。", SAM.JobID)]
    SamuraiYukikazeCombo = 3401,

    [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain. 将月光替换为其连击链。", SAM.JobID)]
    SamuraiGekkoCombo = 3402,

    [ParentCombo(SamuraiGekkoCombo)]
    [CustomComboInfo("Gekko Combo Option", "Start the Gekko combo chain with Jinpu instead of Hakaze. 用阵风开始月光连击链，而不是刃风。", SAM.JobID)]
    SamuraiGekkoOption = 3416,

    [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain. 将花车替换为其连击链。", SAM.JobID)]
    SamuraiKashaCombo = 3403,

    [ParentCombo(SamuraiKashaCombo)]
    [CustomComboInfo("Kasha Combo Option", "Start the Kasha combo chain with Shifu instead of Hakaze. 用士风开始花车连击链，而不是刃风。", SAM.JobID)]
    SamuraiKashaOption = 3417,

    [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain. 将满月替换为其连击链。", SAM.JobID)]
    SamuraiMangetsuCombo = 3404,

    [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain. 将樱花替换为其连击链。", SAM.JobID)]
    SamuraiOkaCombo = 3405,

    [ConflictingCombos(SamuraiIaijutsuTsubameGaeshiFeature)]
    [CustomComboInfo("Tsubame-gaeshi to Iaijutsu", "Replace Tsubame-gaeshi with Iaijutsu when Sen is empty. 当闪为空时，将燕回返替换为居合术。", SAM.JobID)]
    SamuraiTsubameGaeshiIaijutsuFeature = 3407,

    [ConflictingCombos(SamuraiIaijutsuShohaFeature)]
    [CustomComboInfo("Tsubame-gaeshi to Shoha", "Replace Tsubame-gaeshi with Shoha when meditation is 3. 当剑压为3时，将燕回返替换为照破。", SAM.JobID)]
    SamuraiTsubameGaeshiShohaFeature = 3408,

    [ConflictingCombos(SamuraiTsubameGaeshiIaijutsuFeature)]
    [CustomComboInfo("Iaijutsu to Tsubame-gaeshi", "Replace Iaijutsu with Tsubame-gaeshi when Sen is not empty. 当闪不为空时，将居合术替换为燕回返。", SAM.JobID)]
    SamuraiIaijutsuTsubameGaeshiFeature = 3409,

    [ConflictingCombos(SamuraiTsubameGaeshiShohaFeature)]
    [CustomComboInfo("Iaijutsu to Shoha", "Replace Iaijutsu with Shoha when meditation is 3. 当剑压为3时，将居合术替换为照破。", SAM.JobID)]
    SamuraiIaijutsuShohaFeature = 3410,

    [CustomComboInfo("Senei to Guren Level Sync", "Replace Hissatsu: Senei with Guren when level synced below 72. 当等级同步低于72时，将必杀剑·闪影替换为必杀剑·红莲。", SAM.JobID)]
    SamuraiSeneiGurenFeature = 3418,

    [CustomComboInfo("Shinten to Senei", "Replace Hissatsu: Shinten with Senei when available. 当必杀剑·闪影可用时，替换必杀剑·震天。", SAM.JobID)]
    SamuraiShintenSeneiFeature = 3414,

    [CustomComboInfo("Shinten to Shoha", "Replace Hissatsu: Shinten with Shoha when Meditation is full. 当剑压满时，替换必杀剑·震天为照破。", SAM.JobID)]
    SamuraiShintenShohaFeature = 3413,

    [CustomComboInfo("Kyuten to Guren", "Replace Hissatsu: Kyuten with Guren when available. 当必杀剑·红莲可用时，替换必杀剑·九天。", SAM.JobID)]
    SamuraiKyutenGurenFeature = 3415,

    [CustomComboInfo("Kyuten to Shoha II", "Replace Hissatsu: Kyuten with Shoha II when Meditation is full. 当剑压满时，替换必杀剑·九天为无明照破。", SAM.JobID)]
    SamuraiKyutenShoha2Feature = 3412,

    [CustomComboInfo("Ikishoten Namikiri Feature", "Replace Ikishoten with Ogi Namikiri and then Kaeshi Namikiri when available. 当奥义斩浪和回返斩浪可用时，替换意气冲天。", SAM.JobID)]
    SamuraiIkishotenNamikiriFeature = 3411,

    [ParentCombo(SamuraiIkishotenNamikiriFeature)]
    [CustomComboInfo("Ikishoten Shoha Feature", "Replace Ikishoten with Shoha when Meditation is full. 当剑压满时，替换意气冲天为照破。", SAM.JobID)]
    SamuraiIkishotenShohaFeature = 3419,

    #endregion
    // ====================================================================================
    #region SCHOLAR

    [CustomComboInfo("Seraph Fey Blessing/Consolation", "Replace Fey Blessing with Consolation when Seraph is out. 当炽天召唤出现时，将异想的祥光替换为慰藉。", SCH.JobID)]
    ScholarSeraphConsolationFeature = 2801,

    [CustomComboInfo("Lustrate to Recitation", "Replace Lustrate with Recitation when Recitation is off cooldown. 当秘策冷却结束时，将生命活性法替换为秘策。", SCH.JobID)]
    ScholarLustrateRecitationFeature = 2807,

    [CustomComboInfo("Lustrate to Excogitation", "Replace Lustrate with Excogitation when Excogitation is off cooldown. 当深谋远虑之策冷却结束时，将生命活性法替换为深谋远虑之策。", SCH.JobID)]
    ScholarLustrateExcogitationFeature = 2808,

    [CustomComboInfo("Excogitation to Recitation", "Replace Excogitation with Recitation when Recitation is off cooldown. 当秘策冷却结束时，将深谋远虑之策替换为秘策。", SCH.JobID)]
    ScholarExcogitationRecitationFeature = 2806,

    [CustomComboInfo("Excogitation to Lustrate", "Replace Excogitation with Lustrate when Excogitation is on cooldown. 当深谋远虑之策冷却时，将深谋远虑之策替换为生命活性法。", SCH.JobID)]
    ScholarExcogitationLustrateFeature = 2809,

    [CustomComboInfo("ED Aetherflow", "Replace Energy Drain with Aetherflow when you have no more Aetherflow stacks. 当你没有更多的以太超流层数时，将能量吸收替换为以太超流。", SCH.JobID)]
    ScholarEnergyDrainAetherflowFeature = 2802,

    [CustomComboInfo("Lustrous Aetherflow", "Replace Lustrate with Aetherflow when you have no more Aetherflow stacks. 当你没有更多的以太超流层数时，将生命活性法替换为以太超流。", SCH.JobID)]
    ScholarLustrateAetherflowFeature = 2803,

    [CustomComboInfo("Indomitable Aetherflow", "Replace Indomitability with Aetherflow when you have no more Aetherflow stacks. 当你没有更多的以太超流层数时，将不屈不挠之策替换为以太超流。", SCH.JobID)]
    ScholarIndomAetherflowFeature = 2804,

    [CustomComboInfo("Summon Seraph Feature", "Replace Summon Eos and Selene with Summon Seraph when a summon is out. 当有召唤物出现时，将朝日召唤和夕月召唤替换为炽天召唤。", SCH.JobID)]
    ScholarSeraphFeature = 2805,

    [CustomComboInfo("Adloquium Level Sync", "Replace Adloquium with Physick when below level 30 in synced content. 在同步内容中，当等级低于30时，将鼓舞激励之策替换为医术。", SCH.JobID)]
    ScholarAdloquiumSyncFeature = 2810,

    #endregion
    // ====================================================================================
    #region SUMMONER

    [CustomComboInfo("ED Fester Feature", "Change Fester into Energy Drain when out of Aetherflow stacks. 当以太蓄能层数用尽时，将溃烂爆发替换为能量吸收。", SMN.JobID)]
    SummonerEDFesterFeature = 2701,

    [CustomComboInfo("ES Painflare Feature", "Change Painflare into Energy Syphon when out of Aetherflow stacks. 当以太蓄能层数用尽时，将痛苦核爆替换为能量抽取。", SMN.JobID)]
    SummonerESPainflareFeature = 2702,

    [CustomComboInfo("Ruin Feature", "Change Ruin into Gemburst when attuned. 当属性以太时，将毁灭替换为宝石耀。", SMN.JobID)]
    SummonerRuinFeature = 2703,

    [CustomComboInfo("Titan's Favor Ruin Feature", "Change Ruin into Mountain Buster (oGCD) when available. 当可用时，将毁灭替换为山崩(非GCD)", SMN.JobID)]
    SummonerRuinTitansFavorFeature = 2713,

    [CustomComboInfo("Further Ruin Feature", "Change Ruin into Ruin4 when available and appropriate. 当适当且可用时，将毁灭替换为毁绝。", SMN.JobID)]
    SummonerFurtherRuinFeature = 2705,

    [CustomComboInfo("Outburst Feature", "Change Outburst into Precious Brilliance when attuned. 当属性以太时，将迸裂替换为宝石辉。", SMN.JobID)]
    SummonerOutburstFeature = 2704,

    [CustomComboInfo("Titan's Favor Outburst Feature", "Change Outburst into Mountain Buster (oGCD) when available. 当可用时，将迸裂替换为山崩(非GCD)。", SMN.JobID)]
    SummonerOutburstTitansFavorFeature = 2714,

    [CustomComboInfo("Further Outburst Feature", "Change Outburst into Ruin4 when available and appropriate. 当适当且可用时，将迸裂替换为毁绝。", SMN.JobID)]
    SummonerFurtherOutburstFeature = 2706,

    [CustomComboInfo("Shiny Titan's Favor Feature", "Change Gemshine and Precious Brilliance into Mountain Buster (oGCD) when available. 当可用时，将宝石耀和宝石辉替换为山崩(非GCD)。", SMN.JobID)]
    SummonerShinyTitansFavorFeature = 2707,

    [CustomComboInfo("Further Shiny Feature", "Change Gemshine and Precious Brilliance into Ruin4 when available and appropriate. 当适当且可用时，将宝石耀和宝石辉替换为毁绝。", SMN.JobID)]
    SummonerFurtherShinyFeature = 2708,

    [CustomComboInfo("Shiny Enkindle Feature", "Change Gemshine and Precious Brilliance to Enkindle when Bahamut or Phoenix are summoned. 当召唤了巴哈姆特或不死鸟时，将宝石耀和宝石辉替换为内力迸发。", SMN.JobID)]
    SummonerShinyEnkindleFeature = 2709,

    [CustomComboInfo("Demi Enkindle Feature", "Change Summon Bahamut and Summon Phoenix into Enkindle when Bahamut or Phoenix are summoned. 当召唤了巴哈姆特或不死鸟时，将龙神召唤和不死鸟召唤替换为内力迸发。", SMN.JobID)]
    SummonerDemiEnkindleFeature = 2710,

    [CustomComboInfo("Searing Demi Feature", "Change Summon Bahamut and Summon Phoenix into Searing Light when Bahamut is ready to be summoned, Searing Light is off cooldown, and you are in combat. 当巴哈姆特准备召唤，灼热之光冷却结束，并且你处于战斗状态时，将龙神召唤和不死鸟召唤替换为灼热之光。", SMN.JobID)]
    SummonerDemiSearingLightFeature = 2715,

    [CustomComboInfo("Radiant Carbuncle Feature", "Change Radiant Aegis into Summon Carbuncle when no pet has been summoned.当没有召唤宠物时，将守护之光替换为宝石兽召唤。", SMN.JobID)]
    SummonerRadiantCarbuncleFeature = 2711,

    [CustomComboInfo("Demi Carbuncle Feature", "Change Summon Bahamut into Summon Carbuncle when no pet has been summoned. 当没有召唤宠物时，将龙神召唤替换为宝石兽召唤。", SMN.JobID)]
    SummonerDemiCarbuncleFeature = 2716,

    #endregion
    // ====================================================================================
    #region WARRIOR

    [CustomComboInfo("Storms Path Combo", "Replace Storms Path with its combo chain. 将暴风斩替换为其连击链。", WAR.JobID)]
    WarriorStormsPathCombo = 2101,

    [ParentCombo(WarriorStormsPathCombo)]
    [CustomComboInfo("Storms Path Overcap Feature", "Replace Storms Path with Fell Cleave when the next combo action would cause the Beast Gauge to overcap. 当下一个连击动作导致兽魂过量时，将暴风斩替换为裂石飞环。", WAR.JobID)]
    WarriorStormsPathOvercapFeature = 2104,

    [ParentCombo(WarriorStormsPathCombo)]
    [CustomComboInfo("Storms Path Inner Release Feature", "Replace Storms Path with Fell Cleave when Inner Release is active. 当原初的解放激活时，将暴风斩替换为裂石飞环。", WAR.JobID)]
    WarriorStormsPathInnerReleaseFeature = 2110,

    [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain. 将暴风碎替换为其连击链。", WAR.JobID)]
    WarriorStormsEyeCombo = 2102,

    [CustomComboInfo("Mythril Tempest Combo", "Replace Mythril Tempest with its combo chain. 将秘银暴风替换为其连击链。", WAR.JobID)]
    WarriorMythrilTempestCombo = 2103,

    [ParentCombo(WarriorMythrilTempestCombo)]
    [CustomComboInfo("Mythril Tempest Overcap Feature", "Replace Mythril Tempest with Decimate the next combo action would cause the Beast Gauge to overcap. 当下一个连击动作导致兽魂过量时，将秘银暴风替换为地毁人亡。", WAR.JobID)]
    WarriorMythrilTempestOvercapFeature = 2105,

    [ParentCombo(WarriorMythrilTempestCombo)]
    [CustomComboInfo("Mythril Tempest Inner Release Feature", "Replace Mythril Tempest with Decimate when Inner Release is active. 当原初的解放激活时，将秘银暴风替换为地毁人亡。", WAR.JobID)]
    WarriorMythrilTempestInnerReleaseFeature = 2111,

    [CustomComboInfo("Angry Beast Feature", "Replace Inner Beast and Steel Cyclone with Infuriate when less then 50 Beast Gauge is available. 当兽魂低于50时，将原初之魂和钢铁旋风替换为战嚎。", WAR.JobID)]
    WarriorInfuriateBeastFeature = 2109,

    [CustomComboInfo("Nascent Flash Level Sync", "Replace Nascent Flash with Raw intuition when Synced. 同步时，将原初的勇猛替换为原初的直觉。", WAR.JobID)]
    WarriorNascentFlashSyncFeature = 2106,

    [CustomComboInfo("Healthy Balanaced Diet Feature", "Replace Bloodwhetting with Thrill of Battle, and then Equilibrium when the preceding is on cooldown. 当血气勃勃冷却时，将血气勃勃替换为战栗，然后当战栗冷却时替换为泰然自若。", WAR.JobID)]
    WarriorHealthyBalancedDietFeature = 2112,

    [CustomComboInfo("Primal Beast Feature", "Replace Inner Beast and Steel Cyclone with Primal Rend when available. 当蛮荒崩裂可用时，将原初之魂和钢铁旋风替换为蛮荒崩裂。", WAR.JobID)]
    WarriorPrimalBeastFeature = 2107,

    [CustomComboInfo("Primal Release Feature", "Replace Inner Release with Primal Rend when available. 当蛮荒崩裂可用时，将原初的解放替换为蛮荒崩裂。", WAR.JobID)]
    WarriorPrimalReleaseFeature = 2108,

    #endregion
    // ====================================================================================
    #region WHITE MAGE

    [CustomComboInfo("Solace into Misery", "Replace Afflatus Solace with Afflatus Misery when ready. 当苦难之心准备好时，将安慰之心替换为苦难之心。 ", WHM.JobID)]
    WhiteMageSolaceMiseryFeature = 2401,

    [CustomComboInfo("Targeted Misery", "Only swap to Afflatus Misery when targeting an enemy. 只有在目标为敌人时才替换为苦难之心。", WHM.JobID)]
    WhiteMageSolaceMiseryTargetFeature = 2406,

    [CustomComboInfo("Rapture into Misery", "Replace Afflatus Rapture with Afflatus Misery when ready and you have an enemy target. 当苦难之心准备好且你的目标是敌人时，将狂喜之心替换为苦难之心。", WHM.JobID)]
    WhiteMageRaptureMiseryFeature = 2402,

    [CustomComboInfo("Holy into Misery", "Replace Holy/Holy 3 with Afflatus Misery when ready and you have an enemy target. 当苦难之心准备好且你的目标是敌人时，将神圣/豪圣替换为苦难之心。", WHM.JobID)]
    WhiteMageHolyMiseryFeature = 2405,

    [CustomComboInfo("Cure 2 Level Sync", "Replace Cure 2 with Cure when below level 30 in synced content. 在同步内容中，当等级低于30时，将救疗2替换为治疗。", WHM.JobID)]
    WhiteMageCureFeature = 2403,

    [CustomComboInfo("Afflatus Feature", "Replace Cure 2 with Afflatus Solace and Medica with Afflatus Rapture when a Lily is available. 当有神秘百合可用时，将救疗2替换为安慰之心，医治替换为狂喜之心。", WHM.JobID)]
    WhiteMageAfflatusFeature = 2404,

    #endregion
    // ====================================================================================
    #region DOH

    // [CustomComboInfo("Placeholder", "Placeholder.", DOH.JobID)]
    // DohPlaceholder = 50001,

    #endregion
    // ====================================================================================
    #region DOL

    [CustomComboInfo("Eureka Feature", "Replace Ageless Words and Solid Reason with Wise to the World when available.", DOL.JobID)]
    DolEurekaFeature = 51001,

    [CustomComboInfo("Cast / Hook Feature", "Replace Cast with Hook when fishing.", DOL.JobID)]
    DolCastHookFeature = 51002,

    [CustomComboInfo("Cast / Gig Feature", "Replace Cast with Gig when underwater.", DOL.JobID)]
    DolCastGigFeature = 51003,

    [CustomComboInfo("Surface Slap / Veteran Trade Feature", "Replace Surface Slap with Veteran Trade when underwater.", DOL.JobID)]
    DolSurfaceTradeFeature = 51004,

    [CustomComboInfo("Prize Catch / Nature's Bounty Feature", "Replace Prize Catch with Nature's Bounty when underwater.", DOL.JobID)]
    DolPrizeBountyFeature = 51005,

    [CustomComboInfo("Snagging / Salvage Feature", "Replace Snagging with Salvage when underwater.", DOL.JobID)]
    DolSnaggingSalvageFeature = 51006,

    [CustomComboInfo("Cast Light / Electric Current Feature", "Replace Cast Light with Electric Current when underwater.", DOL.JobID)]
    DolCastLightElectricCurrentFeature = 51007,

    #endregion
    // ====================================================================================
}
