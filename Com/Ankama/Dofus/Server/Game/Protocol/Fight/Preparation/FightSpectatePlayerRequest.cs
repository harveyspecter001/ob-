using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x02000697 RID: 1687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSpectatePlayerRequest : IMessage<FightSpectatePlayerRequest>, IMessage, IEquatable<FightSpectatePlayerRequest>, IDeepCloneable<FightSpectatePlayerRequest>, IBufferMessage
	{
		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x0020831C File Offset: 0x0020651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightSpectatePlayerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x0020832C File Offset: 0x0020652C
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x0020833C File Offset: 0x0020653C
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

		// Token: 0x0600523F RID: 21055 RVA: 0x0020834C File Offset: 0x0020654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatePlayerRequest()
		{
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0020835C File Offset: 0x0020655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatePlayerRequest(FightSpectatePlayerRequest other)
		{
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0020836C File Offset: 0x0020656C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatePlayerRequest Clone()
		{
			return null;
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x0020837C File Offset: 0x0020657C
		// (set) Token: 0x06005243 RID: 21059 RVA: 0x0020838C File Offset: 0x0020658C
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

		// Token: 0x06005244 RID: 21060 RVA: 0x0020839C File Offset: 0x0020659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x002083AC File Offset: 0x002065AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSpectatePlayerRequest other)
		{
			return true;
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x002083BC File Offset: 0x002065BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x002083CC File Offset: 0x002065CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x002083DC File Offset: 0x002065DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x002083EC File Offset: 0x002065EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x002083FC File Offset: 0x002065FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x0020840C File Offset: 0x0020660C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSpectatePlayerRequest other)
		{
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x0020841C File Offset: 0x0020661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0020842C File Offset: 0x0020662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x0020843C File Offset: 0x0020663C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSpectatePlayerRequest()
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
					default:
						return;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
						{
							num2 = 2;
						}
						break;
					case 2:
						FightSpectatePlayerRequest._parser = new MessageParser<FightSpectatePlayerRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						goto IL_88;
					}
				}
				IL_88:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00208524 File Offset: 0x00206724
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fpGSIxOPV7q8evJ3CQx7()
		{
			return true;
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x0020852C File Offset: 0x0020672C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSpectatePlayerRequest HPAlqbOP07QO2FpLBNol()
		{
			return null;
		}

		// Token: 0x04001CFF RID: 7423
		private static readonly MessageParser<FightSpectatePlayerRequest> _parser;

		// Token: 0x04001D00 RID: 7424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D01 RID: 7425
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001D02 RID: 7426
		private long playerId_;

		// Token: 0x04001D03 RID: 7427
		private static FightSpectatePlayerRequest Tf4LNfOPrNtqOg4rSMCD;
	}
}
