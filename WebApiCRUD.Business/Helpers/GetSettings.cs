using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCRUD.Business.Helpers
{
    public static class GetSettings
    {
        public static readonly string ConnectionString = GenerateEncryptedString.Decrypt(@"RBLcyR7EvuaUc7gCfSr3WnnDbonffaopuBUAnP1qKOSoKSAw3mu5h1vc/fUtTducSznNPNR1X5Lt9Ii6Z2+II8nnJdQLGPKgA/p803bp2CKjryNI+yTDQQ==");
    }
}
