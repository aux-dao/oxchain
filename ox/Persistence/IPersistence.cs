﻿using OX.Cryptography.ECC;
using OX.IO.Caching;
using OX.IO.Wrappers;
using OX.Ledger;

namespace OX.Persistence
{
    public interface IPersistence
    {
        DataCache<UInt256, BlockState> Blocks { get; }
        DataCache<UInt256, TransactionState> Transactions { get; }
        DataCache<UInt256, NFTState> NFTs { get; }
        DataCache<NFTDonateStateKey, NFTDonateState> NFTDonates { get; }
        DataCache<UInt160, AccountState> Accounts { get; }
        DataCache<UInt256, UnspentCoinState> UnspentCoins { get; }
        DataCache<UInt256, SpentCoinState> SpentCoins { get; }
        DataCache<ECPoint, ValidatorState> Validators { get; }
        DataCache<UInt256, AssetState> Assets { get; }
        DataCache<UInt160, ContractState> Contracts { get; }
        DataCache<StorageKey, StorageItem> Storages { get; }
        DataCache<UInt32Wrapper, HeaderHashList> HeaderHashList { get; }
        MetaDataCache<ValidatorsCountState> ValidatorsCount { get; }
        MetaDataCache<HashIndexState> BlockHashIndex { get; }
        MetaDataCache<HashIndexState> HeaderHashIndex { get; }
    }
}
