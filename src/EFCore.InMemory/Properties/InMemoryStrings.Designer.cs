// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using System.Threading;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.InMemory.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class InMemoryStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.InMemory.Properties.InMemoryStrings", typeof(InMemoryStrings).Assembly);

        /// <summary>
        ///     Attempted to update or delete an entity that does not exist in the store.
        /// </summary>
        public static string UpdateConcurrencyException
            => GetString("UpdateConcurrencyException");

        /// <summary>
        ///     Conflicts were detected for instance of entity type '{entityType}' on the concurrency token properties {properties}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting values.
        /// </summary>
        public static string UpdateConcurrencyTokenException([CanBeNull] object entityType, [CanBeNull] object properties)
            => string.Format(
                GetString("UpdateConcurrencyTokenException", nameof(entityType), nameof(properties)),
                entityType, properties);

        /// <summary>
        ///     Conflicts were detected for instance of entity type '{entityType}' with the key value '{keyValue}' on the concurrency token property values {conflictingValues}, with corresponding database values {databaseValues}.
        /// </summary>
        public static string UpdateConcurrencyTokenExceptionSensitive([CanBeNull] object entityType, [CanBeNull] object keyValue, [CanBeNull] object conflictingValues, [CanBeNull] object databaseValues)
            => string.Format(
                GetString("UpdateConcurrencyTokenExceptionSensitive", nameof(entityType), nameof(keyValue), nameof(conflictingValues), nameof(databaseValues)),
                entityType, keyValue, conflictingValues, databaseValues);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

namespace Microsoft.EntityFrameworkCore.InMemory.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class InMemoryResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.InMemory.Properties.InMemoryStrings", typeof(InMemoryResources).Assembly);

        /// <summary>
        ///     Saved {count} entities to in-memory store.
        /// </summary>
        public static EventDefinition<int> LogSavedChanges([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogSavedChanges;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogSavedChanges,
                    () => new EventDefinition<int>(
                        logger.Options,
                        InMemoryEventId.ChangesSaved,
                        LogLevel.Information,
                        "InMemoryEventId.ChangesSaved",
                        level => LoggerMessage.Define<int>(
                            level,
                            InMemoryEventId.ChangesSaved,
                            _resourceManager.GetString("LogSavedChanges"))));
            }

            return (EventDefinition<int>)definition;
        }

        /// <summary>
        ///     Transactions are not supported by the in-memory store. See http://go.microsoft.com/fwlink/?LinkId=800142
        /// </summary>
        public static EventDefinition LogTransactionsNotSupported([NotNull] IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogTransactionsNotSupported;
            if (definition == null)
            {
                definition = LazyInitializer.EnsureInitialized<EventDefinitionBase>(
                    ref ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogTransactionsNotSupported,
                    () => new EventDefinition(
                        logger.Options,
                        InMemoryEventId.TransactionIgnoredWarning,
                        LogLevel.Warning,
                        "InMemoryEventId.TransactionIgnoredWarning",
                        level => LoggerMessage.Define(
                            level,
                            InMemoryEventId.TransactionIgnoredWarning,
                            _resourceManager.GetString("LogTransactionsNotSupported"))));
            }

            return (EventDefinition)definition;
        }
    }
}
