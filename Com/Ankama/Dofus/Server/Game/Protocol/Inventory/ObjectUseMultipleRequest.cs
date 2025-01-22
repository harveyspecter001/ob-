using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003EC RID: 1004
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectUseMultipleRequest : IMessage<ObjectUseMultipleRequest>, IMessage, IEquatable<ObjectUseMultipleRequest>, IDeepCloneable<ObjectUseMultipleRequest>, IBufferMessage
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x001D264C File Offset: 0x001D084C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectUseMultipleRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x001D265C File Offset: 0x001D085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x001D266C File Offset: 0x001D086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x001D267C File Offset: 0x001D087C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseMultipleRequest()
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x001D268C File Offset: 0x001D088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseMultipleRequest(ObjectUseMultipleRequest other)
		{
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x001D269C File Offset: 0x001D089C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseMultipleRequest Clone()
		{
			return null;
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x001D26AC File Offset: 0x001D08AC
		// (set) Token: 0x06002F4F RID: 12111 RVA: 0x001D26BC File Offset: 0x001D08BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x001D26CC File Offset: 0x001D08CC
		// (set) Token: 0x06002F51 RID: 12113 RVA: 0x001D26DC File Offset: 0x001D08DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x001D26EC File Offset: 0x001D08EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x001D26FC File Offset: 0x001D08FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectUseMultipleRequest other)
		{
			return true;
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x001D270C File Offset: 0x001D090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x001D271C File Offset: 0x001D091C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x001D272C File Offset: 0x001D092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x001D273C File Offset: 0x001D093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x001D274C File Offset: 0x001D094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x001D275C File Offset: 0x001D095C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectUseMultipleRequest other)
		{
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x001D276C File Offset: 0x001D096C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x001D277C File Offset: 0x001D097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x001D278C File Offset: 0x001D098C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectUseMultipleRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_35;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				ObjectUseMultipleRequest._parser = new MessageParser<ObjectUseMultipleRequest>(() => null);
				num = 2;
			}
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x001D2874 File Offset: 0x001D0A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HnDSJtO0Lvo68BQPn4Ii()
		{
			return true;
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x001D287C File Offset: 0x001D0A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectUseMultipleRequest pMEc0mO0Wa9MMm2HpwII()
		{
			return null;
		}

		// Token: 0x040010A1 RID: 4257
		private static readonly MessageParser<ObjectUseMultipleRequest> _parser;

		// Token: 0x040010A2 RID: 4258
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010A3 RID: 4259
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x040010A4 RID: 4260
		private int objectUid_;

		// Token: 0x040010A5 RID: 4261
		public const int QuantityFieldNumber = 2;

		// Token: 0x040010A6 RID: 4262
		private int quantity_;

		// Token: 0x040010A7 RID: 4263
		internal static ObjectUseMultipleRequest C7MGE6O06hFdpT9tlXDt;
	}
}
