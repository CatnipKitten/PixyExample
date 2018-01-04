using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixy
{
    public class PixyCamera
    {
        public bool IsConnected
        {
            get
            {
                int status = pixy.pixy_cam_get_auto_exposure_compensation();
                if (status < 0) return false;
                else return true;
            }
        }

        public int Initialize()
        {
            return pixy.pixy_init();
        }

        public void Close()
        {
            pixy.pixy_close();
        }

        public int GetBlocks(ushort maxCount, BlockArray blocks)
        {
            return pixy.pixy_get_blocks(maxCount, blocks);
        }
    }
}
