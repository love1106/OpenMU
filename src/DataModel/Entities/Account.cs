﻿// <copyright file="Account.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.DataModel.Configuration;

    /// <summary>
    /// The state of an account.
    /// </summary>
    public enum AccountState
    {
        /// <summary>
        /// Normal player account.
        /// </summary>
        Normal,

        /// <summary>
        /// Spectator account, invisible to players and monsters.
        /// </summary>
        Spectator,

        /// <summary>
        /// Game Master account.
        /// </summary>
        GameMaster,

        /// <summary>
        /// Game Master account, invisible to players and monsters.
        /// </summary>
        GameMasterInvisible,

        /// <summary>
        /// Banned account.
        /// </summary>
        Banned,

        /// <summary>
        /// Temporarily banned account.
        /// </summary>
        TemporarilyBanned,
    }

    /// <summary>
    /// The account of a player.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the unique login name.
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or sets the hash of the password, preferrably of BCrypt.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the security code which is used to confirm character deletion and guild kicks.
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        /// Gets or sets the e mail address.
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets the unlocked character classes which are locked by default.
        /// </summary>
        /// <remarks>
        /// Some classes are only available when the player reached a certain level before, or when he paid for some unlock ticket.
        /// </remarks>
        public virtual ICollection<CharacterClass> UnlockedCharacterClasses { get; protected set; }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public AccountState State { get; set; }

        /// <summary>
        /// Gets or sets the timezone of the player, difference to UTC.
        /// </summary>
        public short TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the vault password.
        /// </summary>
        public string VaultPassword { get; set; }

        /// <summary>
        /// Gets or sets the vault.
        /// </summary>
        public virtual ItemStorage Vault { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is vault extended.
        /// </summary>
        public bool IsVaultExtended { get; set; }

        /// <summary>
        /// Gets or sets the characters.
        /// </summary>
        public virtual ICollection<Character> Characters { get; protected set; }
    }
}
