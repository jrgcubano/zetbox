﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrepareEnv
{
    public static class PathX
    {
        public static string Combine(params string[] paths)
        {
            if(paths == null) throw new ArgumentNullException("paths");
            if(paths.Length == 0) throw new ArgumentOutOfRangeException("paths");

            string result = paths[0];

            // Special windows case: if the first part ends with a : (drive letter) append a DirectorySeperator
            if (result.EndsWith(":"))
                result += System.IO.Path.DirectorySeparatorChar;

            for (int i = 1; i < paths.Length; i++)
            {
                result = System.IO.Path.Combine(result, paths[i]);
            }

            return result;
        }
    }
}
