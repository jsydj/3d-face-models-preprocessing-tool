﻿/*  Copyright (C) 2011 Przemyslaw Szeptycki <pszeptycki@gmail.com>, Ecole Centrale de Lyon,

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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;

using PreprocessingFramework;
/**************************************************************************
*
*                          ModelPreProcessing
*
* Copyright (C)         Przemyslaw Szeptycki 2007     All Rights reserved
*
***************************************************************************/

/**
*   @file       ClCheckIfCurvatureHasBeenCalculated.cs
*   @brief      ClCheckIfCurvatureHasBeenCalculated
*   @author     Przemyslaw Szeptycki <pszeptycki@gmail.com>
*   @date       16-03-2009
*
*   @history
*   @item		16-03-2009 Przemyslaw Szeptycki     created at ECL (普查迈克) (بشاماك)
*/
namespace Preprocessing
{
    public class ClCheckIfCurvatureHasBeenCalculated : ClBaseFaceAlgorithm
    {
        public static IFaceAlgorithm CrateAlgorithm()
        {
            return new ClCheckIfCurvatureHasBeenCalculated();
        }

        public static string ALGORITHM_NAME = @"Algorithms\Check\Check If Curvature Has Been Calculated";

        public ClCheckIfCurvatureHasBeenCalculated() : base(ALGORITHM_NAME) { }

        protected override void Algorithm(ref Cl3DModel p_Model)
        {
            //if(!p_Model.m_sExpression.Contains("YR"))
            //    throw new Exception("Not rotation model");

            string fileName = p_Model.ModelFileFolder + p_Model.ModelFileName + ".curv";
            if (File.Exists(fileName))
                throw new Exception("Model has been preprocessed, curvature file has been localized: " + fileName);
            
        }
    }
}

