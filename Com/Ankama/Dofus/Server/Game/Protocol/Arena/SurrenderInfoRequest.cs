using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C30 RID: 3120
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderInfoRequest : IMessage<SurrenderInfoRequest>, IMessage, IEquatable<SurrenderInfoRequest>, IDeepCloneable<SurrenderInfoRequest>, IBufferMessage
	{
		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x060095FB RID: 38395 RVA: 0x00277D0C File Offset: 0x00275F0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SurrenderInfoRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x00277D1C File Offset: 0x00275F1C
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

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x00277D2C File Offset: 0x00275F2C
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

		// Token: 0x060095FE RID: 38398 RVA: 0x00277D3C File Offset: 0x00275F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoRequest()
		{
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x00277D4C File Offset: 0x00275F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoRequest(SurrenderInfoRequest other)
		{
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00277D5C File Offset: 0x00275F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoRequest Clone()
		{
			return null;
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x00277D6C File Offset: 0x00275F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x00277D7C File Offset: 0x00275F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderInfoRequest other)
		{
			return true;
		}

		// Token: 0x06009603 RID: 38403 RVA: 0x00277D8C File Offset: 0x00275F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x00277D9C File Offset: 0x00275F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x00277DAC File Offset: 0x00275FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x00277DBC File Offset: 0x00275FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x00277DCC File Offset: 0x00275FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x00277DDC File Offset: 0x00275FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderInfoRequest other)
		{
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x00277DEC File Offset: 0x00275FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00277DFC File Offset: 0x00275FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x00277E0C File Offset: 0x0027600C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderInfoRequest()
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
						SurrenderInfoRequest._parser = new MessageParser<SurrenderInfoRequest>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						goto IL_6E;
					}
				}
				IL_6E:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x00277EF4 File Offset: 0x002760F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XY8CwYJXPP6jGcQBlJyL()
		{
			return true;
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x00277EFC File Offset: 0x002760FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderInfoRequest VR03dGJXS1PqmZkgjWnk()
		{
			return null;
		}

		// Token: 0x040037D6 RID: 14294
		private static readonly MessageParser<SurrenderInfoRequest> _parser;

		// Token: 0x040037D7 RID: 14295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037D8 RID: 14296
		private static SurrenderInfoRequest naaODcJXiH5Z0p5DbBWg;
	}
}
