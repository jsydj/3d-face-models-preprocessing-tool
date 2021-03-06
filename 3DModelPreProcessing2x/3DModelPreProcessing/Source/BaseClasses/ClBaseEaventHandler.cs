/*  Copyright (C) 2011 Przemyslaw Szeptycki <pszeptycki@gmail.com>, Ecole Centrale de Lyon,

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Diagnostics;
/**************************************************************************
*
*                          ModelPreProcessing
*
* Copyright (C)         Przemyslaw Szeptycki 2007     All Rights reserved
*
***************************************************************************/

/**
*   @file       ClBaseEaventHandler.cs
*   @brief      Base class for all objects which would like to get eavents
*   @author     Przemyslaw Szeptycki <pszeptycki@gmail.com>
*   @date       26-10-2007
*
*   @history
*   @item		26-10-2007 Przemyslaw Szeptycki     created at ECL (普查迈克) (بشاماك)
*/
namespace ModelPreProcessing
{
    public class ClBaseEaventHandler: IEventHandler
    {
        
        protected bool m_bLeftMouseButtonDown = false;
        protected bool m_bRightMouseButtonDown = false;
        protected int m_iMouseButtonDownXpos = 0;
        protected int m_iMouseButtonDownYpos = 0;
        //------------------------------------------------------

        public virtual void MouseButtonDown(object sender, MouseEventArgs e)
        {
            /* You cand override this method to get describing event*/
            if (e.Button == MouseButtons.Left)
                m_bLeftMouseButtonDown = true;

            if (e.Button == MouseButtons.Right)
                m_bRightMouseButtonDown = true;

            m_iMouseButtonDownXpos = e.X;
            m_iMouseButtonDownYpos = e.Y;
        }

        public virtual void MouseButtonUp(object sender, MouseEventArgs e)
        {
            /* You cand override this method to get describing event*/
            if (e.Button == MouseButtons.Left)
                m_bLeftMouseButtonDown = false;

            if (e.Button == MouseButtons.Right)
                m_bRightMouseButtonDown = false;
        }

        public virtual void MouseMove(object sender, MouseEventArgs e)
        {
            /* You cand override this method to get describing event*/
            /* DO NOTHING */
        }

        public virtual void MouseWheel(object sender, MouseEventArgs e)
        {
            /* You cand override this method to get describing event*/
            /* DO NOTHING */
        }

        public virtual void KeyDown(object sender, KeyEventArgs e)
        {
            /* You cand override this method to get describing event*/
            /* DO NOTHING */
        }

        public virtual void KeyUp(object sender, KeyEventArgs e)
        {
            /* You cand override this method to get describing event*/
            /* DO NOTHING */
        }

        public void RegisterForEvent(ClEventSender.eEvents p_eEvent)
        {
            ClEventSender.getInstance().RegisterForEvent(p_eEvent, this);
        }

        public void DeRegisterForAllEvent()
        {
            ClEventSender.getInstance().DeRegisterForAllEvents(this);
        }

        public void DeRegisterForEvent(ClEventSender.eEvents p_eEvent)
        {
            throw new Exception("Method DeregisterForEavent() is not implemented");
        }
    }
}
