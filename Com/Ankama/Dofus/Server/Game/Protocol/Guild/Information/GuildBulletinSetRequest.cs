using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000500 RID: 1280
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildBulletinSetRequest : IMessage<GuildBulletinSetRequest>, IMessage, IEquatable<GuildBulletinSetRequest>, IDeepCloneable<GuildBulletinSetRequest>, IBufferMessage
	{
		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x001E9ACC File Offset: 0x001E7CCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildBulletinSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x001E9ADC File Offset: 0x001E7CDC
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

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x001E9AEC File Offset: 0x001E7CEC
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

		// Token: 0x06003D3B RID: 15675 RVA: 0x001E9AFC File Offset: 0x001E7CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetRequest()
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001E9B0C File Offset: 0x001E7D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetRequest(GuildBulletinSetRequest other)
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x001E9B1C File Offset: 0x001E7D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildBulletinSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x001E9B2C File Offset: 0x001E7D2C
		// (set) Token: 0x06003D3F RID: 15679 RVA: 0x001E9B3C File Offset: 0x001E7D3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
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

		// Token: 0x06003D40 RID: 15680 RVA: 0x001E9B4C File Offset: 0x001E7D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001E9B5C File Offset: 0x001E7D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildBulletinSetRequest other)
		{
			return true;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x001E9B6C File Offset: 0x001E7D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x001E9B7C File Offset: 0x001E7D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x001E9B8C File Offset: 0x001E7D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001E9B9C File Offset: 0x001E7D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x001E9BAC File Offset: 0x001E7DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x001E9BBC File Offset: 0x001E7DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildBulletinSetRequest other)
		{
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x001E9BCC File Offset: 0x001E7DCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x001E9BDC File Offset: 0x001E7DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001E9BEC File Offset: 0x001E7DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildBulletinSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_35;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
						{
							num2 = 2;
						}
						break;
					case 4:
						return;
					}
				}
				IL_35:
				GuildBulletinSetRequest._parser = new MessageParser<GuildBulletinSetRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x001E9CD4 File Offset: 0x001E7ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ha1AkKOTAW3i4rFRuTBc()
		{
			return true;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x001E9CDC File Offset: 0x001E7EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildBulletinSetRequest gR00NYOTBpxQuwt5mCyd()
		{
			return null;
		}

		// Token: 0x0400153E RID: 5438
		private static readonly MessageParser<GuildBulletinSetRequest> _parser;

		// Token: 0x0400153F RID: 5439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001540 RID: 5440
		public const int ContentFieldNumber = 1;

		// Token: 0x04001541 RID: 5441
		private string content_;

		// Token: 0x04001542 RID: 5442
		internal static GuildBulletinSetRequest j6sP1ZOTmC1mYCLAKtva;
	}
}
