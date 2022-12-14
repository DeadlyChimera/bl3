/* Copyright (c) 2019 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Gibbed.Borderlands3.ProtoBufFormats
{
    [ProtoContract]
    public class RegisteredDownloadableEntitlementGroupData : INotifyPropertyChanged
    {
        #region Fields
        private string _EntitlementSource;
        private List<long> _EntitlementIDs;
        private List<RegisteredDownloadableEntitlementData> _Entitlements;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string EntitlementSource
        {
            get { return this._EntitlementSource; }
            set
            {
                if (value != this._EntitlementSource)
                {
                    this._EntitlementSource = value;
                    this.NotifyOfPropertyChange(nameof(EntitlementSource));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public List<long> EntitlementIDs
        {
            get { return this._EntitlementIDs; }
            set
            {
                if (value != this._EntitlementIDs)
                {
                    this._EntitlementIDs = value;
                    this.NotifyOfPropertyChange(nameof(EntitlementIDs));
                }
            }
        }

        [ProtoMember(3, IsRequired = true)]
        public List<RegisteredDownloadableEntitlementData> Entitlements
        {
            get { return this._Entitlements; }
            set
            {
                if (value != this._Entitlements)
                {
                    this._Entitlements = value;
                    this.NotifyOfPropertyChange(nameof(Entitlements));
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
