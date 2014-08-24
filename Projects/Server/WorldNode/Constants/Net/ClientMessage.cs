﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace WorldNode.Constants.Net
{
    // Value '0x2000' means not updated/implemented
    enum ClientMessage : ushort
    {
        #region Player
        InitiateTrade                                 = 0x2000,
        BeginTrade                                    = 0x2000,
        BusyTrade                                     = 0x2000,
        IgnoreTrade                                   = 0x2000,
        AcceptTrade                                   = 0x2000,
        UnacceptTrade                                 = 0x2000,
        CancelTrade                                   = 0x2000,
        SetTradeItem                                  = 0x2000,
        ClearTradeItem                                = 0x2000,
        SetTradeGold                                  = 0x2000,
        SetTradeCurrency                              = 0x2000,
        RequestResearchHistory                        = 0x2000,
        SetPetSlot                                    = 0x2000,
        SetCurrencyFlags                              = 0x2000,
        BFMgrQueueRequest                             = 0x2000,
        BattlefieldLeave                              = 0x2000,
        QueryQuestCompletionNPCs                      = 0x2000,
        RequestCemeteryList                           = 0x2000,
        SetPreferredCemetery                          = 0x2000,
        JoinRatedBattleground                         = 0x2000,
        RequestHonorStats                             = 0x2000,
        PVPLogData                                    = 0x2000,
        RequestCategoryCooldowns                      = 0x2000,
        BattlefieldList                               = 0x2000,
        CancelQueuedSpell                             = 0x2000,
        ObjectUpdateFailed                            = 0x2000,
        ObjectUpdateRescued                           = 0x2000,
        ViolenceLevel                                 = 0x2000,
        UsedFollow                                    = 0x2000,
        StandStateChange                              = 0x2000,
        UpdateMissileTrajectory                       = 0x2000,
        MissileTrajectoryCollision                    = 0x2000,
        SaveCUFProfiles                               = 0x2000,
        RequestPVPRewards                             = 0x2000,
        TransmogrifyItems                             = 0x2000,
        UnlockVoidStorage                             = 0x2000,
        QueryVoidStorage                              = 0x2000,
        VoidStorageTransfer                           = 0x2000,
        SwapVoidItem                                  = 0x2000,
        UnlearnSpecialization                         = 0x2000,
        ClearRaidMarker                               = 0x2000,
        RequestGuildRewardsList                       = 0x2000,
        RequestGuildPartyState                        = 0x2000,
        QueryCountdownTimer                           = 0x2000,
        SetSpecialization                             = 0x2000,
        LearnTalents                                  = 0x2000,
        LearnPetSpecializationGroup                   = 0x2000,
        CancelModSpeedNoControlAuras                  = 0x2000,
        CancelAura                                    = 0x2000,
        NeutralPlayerSelectFaction                    = 0x2000,
        AreaTrigger                                   = 0x2000,
        PetBattleRequestWild                          = 0x2000,
        PetBattleWildLocationFail                     = 0x2000,
        PetBattleRequestPVP                           = 0x2000,
        PetBattleRequestUpdate                        = 0x2000,
        JoinPetBattleQueue                            = 0x2000,
        LeavePetBattleQueue                           = 0x2000,
        BattlePetUpdateNotify                         = 0x2000,
        PetBattleQuitNotify                           = 0x2000,
        PetBattleFinalNotify                          = 0x2000,
        PetBattleScriptErrorNotify                    = 0x2000,
        CageBattlePet                                 = 0x2000,
        ResetChallengeMode                            = 0x2000,
        RequestForcedReactions                        = 0x2000,
        IncreaseCastTimeForSpell                      = 0x2000,
        ConfirmRespecWipe                             = 0x2000,
        LootUnit                                      = 0x2000,
        LootMoney                                     = 0x2000,
        LootItem                                      = 0x2000,
        MasterLootItem                                = 0x2000,
        DoMasterLootRoll                              = 0x2000,
        CancelMasterLootRoll                          = 0x2000,
        LootRelease                                   = 0x2000,
        LootRoll                                      = 0x2000,
        ScenePlaybackComplete                         = 0x2000,
        ScenePlaybackCanceled                         = 0x2000,
        SceneTriggerEvent                             = 0x2000,
        SetDifficultyID                               = 0x2000,
        KeyboundOverride                              = 0x2000,
        PetBattleQueueProposeMatchResult              = 0x2000,
        MailDelete                                    = 0x2000,
        SetAchievementsHidden                         = 0x2000,
        UpgradeItem                                   = 0x2000,
        RequestVehicleExit                            = 0x2000,
        RequestVehiclePrevSeat                        = 0x2000,
        RequestVehicleNextSeat                        = 0x2000,
        RequestVehicleSwitchSeat                      = 0x2000,
        RideVehicleInteract                           = 0x2000,
        EjectPassenger                                = 0x2000,
        UseCritterItem                                = 0x2000,
        AttackSwing                                   = 0x2000,
        AttackStop                                    = 0x2000,
        CancelChannelling                             = 0x2000,
        CancelGrowthAura                              = 0x2000,
        QueryCreature                                 = 0x2000,
        QueryGameObject                               = 0x2000,
        QueryNPCText                                  = 0x2000,
        QueryQuestInfo                                = 0x2000,
        QueryPageText                                 = 0x2000,
        QueryPetName                                  = 0x2000,
        QueryBattlePetName                            = 0x2000,
        QueryPetition                                 = 0x2000,
        RequestPlayedTime                             = 0x2000,
        SetTitle                                      = 0x2000,
        CancelMountAura                               = 0x2000,
        MountSpecialAnim                              = 0x2000,
        DestroyItem                                   = 0x2000,
        GetMirrorImageData                            = 0x2000,
        UseItem                                       = 0x2000,
        UseToy                                        = 0x2000,
        PetCastSpell                                  = 0x2000,
        CastSpell                                     = 0x2000,
        CancelCast                                    = 0x2000,
        ChoiceResponse                                = 0x2000,
        SetLFGBonusFactionID                          = 0x2000,
        RequestLFGListBlacklist                       = 0x2000,
        SaveGuildEmblem                               = 0x2000,
        TabardVendorActivate                          = 0x2000,
        TogglePVP                                     = 0x2000,
        SetPVP                                        = 0x2000,
        BattlemasterHello                             = 0x2000,
        RequestConquestFormulaConstants               = 0x2000,
        SetAdvancedCombatLogging                      = 0x2000,
        UpgradeGarrison                               = 0x2000,
        GarrisonSetActiveBuildingSpecialization       = 0x2000,
        GetGarrisonInfo                               = 0x2000,
        GarrisonRequestBlueprintAndSpecializationData = 0x2000,
        GarrisonPurchaseBuilding                      = 0x2000,
        GarrisonSetBuildingActive                     = 0x2000,
        GarrisonAssignFollowerToBuilding              = 0x2000,
        GarrisonRemoveFollowerFromBuilding            = 0x2000,
        OpenShipmentNPC                               = 0x2000,
        GetShipmentInfo                               = 0x2000,
        CreateShipment                                = 0x2000,
        CompleteAllReadyShipments                     = 0x2000,
        GetTrophyList                                 = 0x2000,
        ReplaceTrophy                                 = 0x2000,
        GarrisonStartMission                          = 0x2000,
        GarrisonCompleteMission                       = 0x2000,
        GarrisonMissionBonusRoll                      = 0x2000,
        ItemTextQuery                                 = 0x2000,
        OpenItem                                      = 0x2000,
        ReadItem                                      = 0x2000,
        ChangeBagSlotFlag                             = 0x2000,
        SetBackpackAutosortDisabled                   = 0x2000,
        SetBankAutosortDisabled                       = 0x2000,
        SetBankBagSlotAutosortDisabled                = 0x2000,
        SortBags                                      = 0x2000,
        SortBankBags                                  = 0x2000,
        #endregion

        #region PlayerGameEvent
        SendTextEmote                                 = 0x2000,
        SetSheathed                                   = 0x2000,
        PetSetAction                                  = 0x2000,
        PetAction                                     = 0x2000,
        PetStopAttack                                 = 0x2000,
        PetAbandon                                    = 0x2000,
        PetCancelAura                                 = 0x2000,
        PetSpellAutocast                              = 0x2000,
        RequestPetInfo                                = 0x2000,
        RequestStabledPets                            = 0x2000,
        TalkToGossip                                  = 0x2000,
        GossipSelectOption                            = 0x2000,
        SpellClick                                    = 0x2000,
        QuestGiverHello                               = 0x2000,
        QuestGiverQueryQuest                          = 0x2000,
        QuestGiverAcceptQuest                         = 0x2000,
        QuestGiverCompleteQuest                       = 0x2000,
        QuestGiverChooseReward                        = 0x2000,
        QuestGiverRequestReward                       = 0x2000,
        QuestGiverStatusQuery                         = 0x2000,
        QuestGiverStatusMultipleQuery                 = 0x2000,
        QuestConfirmAccept                            = 0x2000,
        PushQuestToParty                              = 0x2000,
        QuestPushResult                               = 0x2000,
        ListInventory                                 = 0x2000,
        SellItem                                      = 0x2000,
        BuyItem                                       = 0x2000,
        BuyBackItem                                   = 0x2000,
        TaxiNodeStatusQuery                           = 0x2000,
        EnableTaxiNode                                = 0x2000,
        TaxiQueryAvailableNodes                       = 0x2000,
        ActivateTaxi                                  = 0x2000,
        ActivateTaxiExpress                           = 0x2000,
        TrainerList                                   = 0x2000,
        TrainerBuySell                                = 0x2000,
        SpiritHealerActivate                          = 0x2000,
        AreaSpiritHealerQuery                         = 0x2000,
        AreaSpiritHealerQueue                         = 0x2000,
        BinderActivate                                = 0x2000,
        BankerActivate                                = 0x2000,
        BuyBankSlot                                   = 0x2000,
        GuildBankActivate                             = 0x2000,
        GuildBankSwapItems                            = 0x2000,
        GuildBankQueryTab                             = 0x2000,
        GuildBankBuyTab                               = 0x2000,
        GuildBankUpdateTab                            = 0x2000,
        GuildBankDepositMoney                         = 0x2000,
        GuildBankWithdrawMoney                        = 0x2000,
        PetitionShowList                              = 0x2000,
        PetitionBuy                                   = 0x2000,
        PetitionShowSignatures                        = 0x2000,
        AuctionHelloRequest                           = 0x2000,
        AuctionSellItem                               = 0x2000,
        AuctionRemoveItem                             = 0x2000,
        AuctionListItems                              = 0x2000,
        AuctionReplicateItems                         = 0x2000,
        AuctionListOwnerItems                         = 0x2000,
        AuctionListBidderItems                        = 0x2000,
        AuctionPlaceBid                               = 0x2000,
        AuctionListPendingSales                       = 0x2000,
        QueryTime                                     = 0x2000,
        LogoutRequest                                 = 0x2000,
        LogoutCancel                                  = 0x2000,
        LogoutInstant                                 = 0x2000,
        ReclaimCorpse                                 = 0x2000,
        CompleteMovie                                 = 0x2000,
        SetFactionAtWar                               = 0x2000,
        SetFactionNotAtWar                            = 0x2000,
        SetFactionInactive                            = 0x2000,
        SetWatchedFaction                             = 0x2000,
        DuelResponse                                  = 0x2000,
        UnlearnSkill                                  = 0x2000,
        CancelAutoRepeatSpell                         = 0x2000,
        FarSight                                      = 0x2000,
        SocketGems                                    = 0x2000,
        RepairItem                                    = 0x2000,
        ShowingHelm                                   = 0x2000,
        ShowingCloak                                  = 0x2000,
        GameObjUse                                    = 0x2000,
        GameObjReportUse                              = 0x2000,
        CancelTempEnchantment                         = 0x2000,
        SetTaxiBenchmarkMode                          = 0x2000,
        ReportPvPPlayerAFK                            = 0x2000,
        AlterAppearance                               = 0x2000,
        OptOutOfLoot                                  = 0x2000,
        GrantLevel                                    = 0x2000,
        AcceptLevelGrant                              = 0x2000,
        TotemDestroyed                                = 0x2000,
        DismissCritter                                = 0x2000,
        QueryInspectAchievements                      = 0x2000,
        HearthAndResurrect                            = 0x2000,
        SaveEquipmentSet                              = 0x2000,
        DeleteEquipmentSet                            = 0x2000,
        InstanceLockResponse                          = 0x2000,
        LowLevelRaid                                  = 0x2000,
        DeclineGuildInvites                           = 0x2000,
        BattlemasterJoin                              = 0x2000,
        BattlemasterJoinArena                         = 0x2000,
        BattlefieldPort                               = 0x2000,
        RepopRequest                                  = 0x2000,
        entPortGraveyard                              = 0x2000,
        SetSelection                                  = 0x2000,
        Inspect                                       = 0x2000,
        BlackMarketOpen                               = 0x2000,
        BlackMarketRequestItems                       = 0x2000,
        BlackMarketBidOnItem                          = 0x2000,
        QuestLogRemoveQuest                           = 0x2000,
        GetItemPurchaseData                           = 0x2000,
        ItemPurchaseRefund                            = 0x2000,
        SelfRes                                       = 0x2000,
        SetActionBarToggles                           = 0x2000,
        SignPetition                                  = 0x2000,
        DeclinePetition                               = 0x2000,
        TurnInPetition                                = 0x2000,
        MailGetList                                   = 0x2000,
        MailTakeMoney                                 = 0x2000,
        MailTakeItem                                  = 0x2000,
        QueryNextMailTime                             = 0x2000,
        MailMarkAsRead                                = 0x2000,
        MailCreateTextItem                            = 0x2000,
        SetLootSpecialization                         = 0x2000,
        Emote                                         = 0x2000,
        OpeningCinematic                              = 0x2000,
        NextCinematicCamera                           = 0x2000,
        CompleteCinematic                             = 0x2000,
        #endregion

        #region PlayerInventory
        WrapItem                                      = 0x2000,
        UseEquipmentSet                               = 0x2000,
        AutostoreBankItem                             = 0x2000,
        AutobankItem                                  = 0x2000,
        AutoEquipItem                                 = 0x2000,
        AutoStoreBagItem                              = 0x2000,
        SwapItem                                      = 0x2000,
        SwapInvItem                                   = 0x2000,
        SplitItem                                     = 0x2000,
        AutoEquipItemSlot                             = 0x2000,
        #endregion

        #region PlayerMovement
        StartForward                                  = 0x2000,
        StartBackward                                 = 0x2000,
        Stop                                          = 0x2000,
        StartStrafeLeft                               = 0x2000,
        StartStrafeRight                              = 0x2000,
        StopStrafe                                    = 0x2000,
        Jump                                          = 0x2000,
        StartTurnLeft                                 = 0x2000,
        StartTurnRight                                = 0x2000,
        StopTurn                                      = 0x2000,
        StartPitchUp                                  = 0x2000,
        StartPitchDown                                = 0x2000,
        StopPitch                                     = 0x2000,
        SetRunMode                                    = 0x2000,
        SetWalkMode                                   = 0x2000,
        TeleportCheat                                 = 0x2000,
        CharmTeleportCheat                            = 0x2000,
        SetRelativePosition                           = 0x2000,
        TeleportAck                                   = 0x2000,
        FallLand                                      = 0x2000,
        StartSwim                                     = 0x2000,
        StopSwim                                      = 0x2000,
        ToggleCollisionCheat                          = 0x2000,
        SetFacing                                     = 0x2000,
        SetPitch                                      = 0x2000,
        ForceRunSpeedChangeAck                        = 0x2000,
        ForceRunBackSpeedChangeAck                    = 0x2000,
        ForceSwimSpeedChangeAck                       = 0x2000,
        ForceRootAck                                  = 0x2000,
        ForceUnrootAck                                = 0x2000,
        Heartbeat                                     = 0x2000,
        KnockBackAck                                  = 0x2000,
        HoverAck                                      = 0x2000,
        SetVehicleRecIdAck                            = 0x2000,
        ApplyMovementForceAck                         = 0x2000,
        RemoveMovementForceAck                        = 0x2000,
        RemoveMovementForces                          = 0x2000,
        SplineDone                                    = 0x2000,
        FallReset                                     = 0x2000,
        TimeSkipped                                   = 0x2000,
        FeatherFallAck                                = 0x2000,
        WaterWalkAck                                  = 0x2000,
        ForceWalkSpeedChangeAck                       = 0x2000,
        ForceSwimBackSpeedChangeAck                   = 0x2000,
        ForceTurnRateChangeAck                        = 0x2000,
        EnableSwimToFlyTransAck                       = 0x2000,
        SetCanTurnWhileFallingAck                     = 0x2000,
        SetIgnoreMovementForcesAck                    = 0x2000,
        SetCanFlyAck                                  = 0x2000,
        SetFly                                        = 0x2000,
        StartAscend                                   = 0x2000,
        StopAscend                                    = 0x2000,
        ForceFlightSpeedChangeAck                     = 0x2000,
        ForceFlightBackSpeedChangeAck                 = 0x2000,
        ChangeTransport                               = 0x2000,
        StartDescend                                  = 0x2000,
        ForcePitchRateChangeAck                       = 0x2000,
        DismissVehicle                                = 0x2000,
        ChangeVehicleSeats                            = 0x2000,
        GravityDisableAck                             = 0x2000,
        GravityEnableAck                              = 0x2000,
        SetCollisionHeightAck                         = 0x2000,
        SetActiveMover                                = 0x2000,
        TimeSyncResponse                              = 0x2000,
        TimeSyncResponseFailed                        = 0x2000,
        TimeSyncResponseDropped                       = 0x2000,
        TimeAdjustmentResponse                        = 0x2000,
        DiscardedTimeSyncAcks                         = 0x2000,
        #endregion
    }
}