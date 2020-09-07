using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Modbus.Device;


namespace DeviceHelper
{
    public enum analogTag
    {
        Tag0,
        Tag1,
        Tag2,
        Tag3,
        Tag4
    }
    public enum digitalTag
    {
        Tag0,
        Tag1,
        Tag2,
        Tag3,
        Tag4
    }
    public struct TagAnalogValue
    {
        float oldValue;
        float newValue;
    }
    public struct TagDigitalValue 
    {
        bool oldValue;
        bool newValue;
    }
    public class ModbusDevice
    {
        private string tcpArdess;
        private int tcpPort;
        public TcpClient client;
        private ModbusIpMaster master;
        private Dictionary<analogTag, TagAnalogValue> aD;
        private Dictionary<digitalTag, TagDigitalValue> dD;
        public ModbusDevice(string ipArdess, int port)
        {
            client = new TcpClient(ipArdess, port);
            ModbusIpMaster master = ModbusIpMaster.CreateIp(client);
        }
        public float getAnalogValue(byte slaveId, ushort adress)
        {
            const int SIZE = 2;
            return ConvertToSingle(master.ReadHoldingRegisters(slaveId, adress, SIZE));
        }
        public bool getDigitalValue(byte slaveId, ushort adress, int position)
        {
            const int SIZE = 1;
            const int INDEX = 0;
            return GetBit(master.ReadHoldingRegisters(slaveId, adress, SIZE)[INDEX], position);
        }
        private static float ConvertToSingle(ushort[] input)
        {
            const int EXP_SIZE = 2;
            float val = -1.0f;
            if (input.Length == EXP_SIZE)
            {
                byte[] value = BitConverter.GetBytes(input[0])
                .Concat(BitConverter.GetBytes(input[1]))
                .ToArray();
                val = BitConverter.ToSingle(value, 0);
            }
            return val;
        }
        bool GetBit(ushort raw, int position)
        {
            return (raw & (1 << position)) != 0;
        }
    }
}
