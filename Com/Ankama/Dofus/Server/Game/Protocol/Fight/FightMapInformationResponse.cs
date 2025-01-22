using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000692 RID: 1682
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMapInformationResponse : IMessage<FightMapInformationResponse>, IMessage, IEquatable<FightMapInformationResponse>, IDeepCloneable<FightMapInformationResponse>, IBufferMessage
	{
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x00206B08 File Offset: 0x00204D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightMapInformationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x00206B18 File Offset: 0x00204D18
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x00206B28 File Offset: 0x00204D28
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

		// Token: 0x06005201 RID: 20993 RVA: 0x00206B38 File Offset: 0x00204D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationResponse()
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00206B48 File Offset: 0x00204D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationResponse(FightMapInformationResponse other)
		{
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00206B58 File Offset: 0x00204D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightMapInformationResponse Clone()
		{
			return null;
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00206B68 File Offset: 0x00204D68
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x00206B78 File Offset: 0x00204D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x00206B88 File Offset: 0x00204D88
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00206B98 File Offset: 0x00204D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FightMapId
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x00206BA8 File Offset: 0x00204DA8
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00206BB8 File Offset: 0x00204DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightStartingPositions FightStartPositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00206BC8 File Offset: 0x00204DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00206BD8 File Offset: 0x00204DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightMapInformationResponse other)
		{
			return true;
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00206BE8 File Offset: 0x00204DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00206BF8 File Offset: 0x00204DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00206C08 File Offset: 0x00204E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00206C18 File Offset: 0x00204E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00206C28 File Offset: 0x00204E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00206C38 File Offset: 0x00204E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightMapInformationResponse other)
		{
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00206C48 File Offset: 0x00204E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00206C58 File Offset: 0x00204E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00206C68 File Offset: 0x00204E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightMapInformationResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						break;
					case 3:
						goto IL_9B;
					case 4:
						return;
					}
				}
				IL_9B:
				FightMapInformationResponse._parser = new MessageParser<FightMapInformationResponse>(() => null);
				num = 4;
			}
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00206D38 File Offset: 0x00204F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NTOBt7OP1iPYHEog93R2()
		{
			return true;
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x00206D40 File Offset: 0x00204F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightMapInformationResponse CljpVXOPaTn393iuVtx4()
		{
			return null;
		}

		// Token: 0x04001CE9 RID: 7401
		private static readonly MessageParser<FightMapInformationResponse> _parser;

		// Token: 0x04001CEA RID: 7402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CEB RID: 7403
		public const int MapIdFieldNumber = 1;

		// Token: 0x04001CEC RID: 7404
		private long mapId_;

		// Token: 0x04001CED RID: 7405
		public const int FightMapIdFieldNumber = 2;

		// Token: 0x04001CEE RID: 7406
		private long fightMapId_;

		// Token: 0x04001CEF RID: 7407
		public const int FightStartPositionsFieldNumber = 3;

		// Token: 0x04001CF0 RID: 7408
		private FightStartingPositions fightStartPositions_;

		// Token: 0x04001CF1 RID: 7409
		private static FightMapInformationResponse U3jepKOPoxAQrQ8odS6O;
	}
}
