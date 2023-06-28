// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PortBridgeClientAgent {
    [RunInstaller(true)]
    public partial class ServiceInstaller : System.Configuration.Install.Installer {
        public ServiceInstaller()
        {
            InitializeComponent();
        }
    }
}