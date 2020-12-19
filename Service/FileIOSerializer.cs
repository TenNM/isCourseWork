using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace isCourseWork
{
    internal abstract class FileIOSerializer
    {
        internal const string SAVE_ERR = "Save error";
        internal const string LOAD_ERR = "Load error";
        //------------------------------------------------binary serialization, save, load
        internal static void save(object saveableObj, string path)
        {
            var binFormatter = new BinaryFormatter();
            using (var fStream = new FileStream(path, FileMode.Create))
            {
                binFormatter.Serialize(fStream, saveableObj);
            }
        }
        internal static void save(object saveableObj, Stream fs)
        {
            var binFormatter = new BinaryFormatter();
            try
            {
                binFormatter.Serialize(fs, saveableObj);
            }
            catch { throw new System.Exception(SAVE_ERR); }
        }
        //--------------------------------------------------------------------------
        internal static void load<T>(ref T loadableObj, string path) where T : class
        {
            var binFormatter = new BinaryFormatter();
            using (var fStream = new FileStream(path, FileMode.Open))
            {
                loadableObj = binFormatter.Deserialize(fStream) as T;
            }
        }
        internal static void load<T>(ref T loadableObj, Stream fs) where T : class
        {
            var binFormatter = new BinaryFormatter();
            try
            {
                loadableObj = binFormatter.Deserialize(fs) as T;
            }
            catch { throw new System.Exception(LOAD_ERR); }
        }
        //---------------------------------------------------------------------------
    }
}