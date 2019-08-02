using System;
using Agilite.Library;
using Agilite.Models;

namespace Agilite
{
    /// <summary>
    /// Class Agilite.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class Agilite : IDisposable
    {
        /// <summary>
        /// The BPM
        /// </summary>
        public readonly Bpm Bpm;
        /// <summary>
        /// The connectors
        /// </summary>
        public readonly Connectors Connectors;
        /// <summary>
        /// The data mapping
        /// </summary>
        public readonly DataMapping DataMapping;
        /// <summary>
        /// The files
        /// </summary>
        public readonly Files Files;
        /// <summary>
        /// The keywords
        /// </summary>
        public readonly Keywords Keywords;
        /// <summary>
        /// The numbering
        /// </summary>
        public readonly Numbering Numbering;
        /// <summary>
        /// The roles
        /// </summary>
        public readonly Roles Roles;
        /// <summary>
        /// The templates
        /// </summary>
        public readonly Templates Templates;
        /// <summary>
        /// The tier structures
        /// </summary>
        public readonly TierStructures TierStructures;
        /// <summary>
        /// The utils
        /// </summary>
        public readonly Utils Utils;

        /// <summary>
        /// Initializes a new instance of the <see cref="Agilite"/> class.
        /// </summary>
        /// <param name="baseConfig">The base configuration.</param>
        /// <exception cref="ArgumentNullException">ApiKey</exception>
        public Agilite(AgiliteConfig baseConfig)
        {
            if (string.IsNullOrEmpty(baseConfig.ApiKey)) throw new ArgumentNullException(nameof(baseConfig.ApiKey));

            Keywords = new Keywords(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Numbering = new Numbering(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Connectors = new Connectors(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            DataMapping = new DataMapping(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Bpm = new Bpm(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Roles = new Roles(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Templates = new Templates(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Utils = new Utils(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            Files = new Files(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
            TierStructures = new TierStructures(new AgiliteRequestConfig {AgiliteConfig = baseConfig});
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            
        }
    }
}