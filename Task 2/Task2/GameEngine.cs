using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

namespace TASK1
{
    [Serializable()]

    class GameEngine : ISerializable
    {
        
        private Map map;

        public Map MAP { get => map; set => map = value; }

        public GameEngine()
        {
            MAP = new Map(4, 10, 4, 10, 3);
        }

        public bool MovePlayer(Character.Movement direction)
        {

        }

        public void EnemyAttacks()
        {
            
        }

        public void MoveEnemies()
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Map", map);
        }

        public void Save()
        {
            map = new Map(4, 10, 4, 10, 3, 4);

            if (File.Exists("MapData"))
            {
                Stream stream = File.Open("MapData.dat", FileMode.Open);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, map);
                stream.Close();
            }
            else
            {
                Stream stream = File.Open("MapData.dat", FileMode.Create);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, map);
                stream.Close();
            }
        }
        public GameEngine(SerializationInfo info, StreamingContext context)
        {
            map = (string)info.GetValue("Map", typeof(string));
        }

        public void Load()
        {
            map = null;

            Stream stream = File.Open("MapData.dat", FileMode.Open);
            BinaryFormatter Bin = new BinaryFormatter();

            map = (Map)Bin.Deserialize(stream);
            stream.Close();

        }
    }
}
