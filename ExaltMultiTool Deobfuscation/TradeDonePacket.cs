﻿using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009A RID: 154
internal class TradeDonePacket : Packet
{
	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000441 RID: 1089 RVA: 0x00016C6C File Offset: 0x00014E6C
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADEDONE;
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00016C7C File Offset: 0x00014E7C
	public override void Read(PacketReader r)
	{
		this.Result = r.ReadInt32();
		this.Message = r.ReadString();
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00016CA4 File Offset: 0x00014EA4
	public override void Write(PacketWriter w)
	{
		w.Write(this.Result);
		w.Write(this.Message);
	}

	// Token: 0x04000573 RID: 1395
	public int Result;

	// Token: 0x04000574 RID: 1396
	public string Message;
}
