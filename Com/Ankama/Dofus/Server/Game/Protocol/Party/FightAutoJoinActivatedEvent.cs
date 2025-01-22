using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002B8 RID: 696
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinActivatedEvent : IMessage<FightAutoJoinActivatedEvent>, IMessage, IEquatable<FightAutoJoinActivatedEvent>, IDeepCloneable<FightAutoJoinActivatedEvent>, IBufferMessage
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x001B9E2C File Offset: 0x001B802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoJoinActivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x001B9E3C File Offset: 0x001B803C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x001B9E4C File Offset: 0x001B804C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x001B9E5C File Offset: 0x001B805C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivatedEvent()
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x001B9E6C File Offset: 0x001B806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivatedEvent(FightAutoJoinActivatedEvent other)
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x001B9E7C File Offset: 0x001B807C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x001B9E8C File Offset: 0x001B808C
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x001B9E9C File Offset: 0x001B809C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x001B9EAC File Offset: 0x001B80AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x001B9EBC File Offset: 0x001B80BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinActivatedEvent other)
		{
			return true;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x001B9ECC File Offset: 0x001B80CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x001B9EDC File Offset: 0x001B80DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x001B9EEC File Offset: 0x001B80EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x001B9EFC File Offset: 0x001B80FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x001B9F0C File Offset: 0x001B810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x001B9F1C File Offset: 0x001B811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinActivatedEvent other)
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x001B9F2C File Offset: 0x001B812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x001B9F3C File Offset: 0x001B813C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x001B9F4C File Offset: 0x001B814C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinActivatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					FightAutoJoinActivatedEvent._parser = new MessageParser<FightAutoJoinActivatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x001BA018 File Offset: 0x001B8218
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v76uqbO6X672pk7BoH1X()
		{
			return true;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x001BA020 File Offset: 0x001B8220
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinActivatedEvent pBXR6aO6NGu9yygeSWrr()
		{
			return null;
		}

		// Token: 0x04000B5D RID: 2909
		private static readonly MessageParser<FightAutoJoinActivatedEvent> _parser;

		// Token: 0x04000B5E RID: 2910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B5F RID: 2911
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B60 RID: 2912
		private long playerId_;

		// Token: 0x04000B61 RID: 2913
		private static FightAutoJoinActivatedEvent RSPwbHO6E5HkunJfv2d2;
	}
}
