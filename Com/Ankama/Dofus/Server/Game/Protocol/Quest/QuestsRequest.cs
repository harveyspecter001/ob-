using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x02000199 RID: 409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestsRequest : IMessage<QuestsRequest>, IMessage, IEquatable<QuestsRequest>, IDeepCloneable<QuestsRequest>, IBufferMessage
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x001A3D5C File Offset: 0x001A1F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QuestsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x001A3D6C File Offset: 0x001A1F6C
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x001A3D7C File Offset: 0x001A1F7C
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

		// Token: 0x060012F9 RID: 4857 RVA: 0x001A3D8C File Offset: 0x001A1F8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsRequest()
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x001A3D9C File Offset: 0x001A1F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsRequest(QuestsRequest other)
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x001A3DAC File Offset: 0x001A1FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsRequest Clone()
		{
			return null;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x001A3DBC File Offset: 0x001A1FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x001A3DCC File Offset: 0x001A1FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestsRequest other)
		{
			return true;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x001A3DDC File Offset: 0x001A1FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x001A3DEC File Offset: 0x001A1FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x001A3DFC File Offset: 0x001A1FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x001A3E0C File Offset: 0x001A200C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x001A3E1C File Offset: 0x001A201C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x001A3E2C File Offset: 0x001A202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestsRequest other)
		{
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x001A3E3C File Offset: 0x001A203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x001A3E4C File Offset: 0x001A204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x001A3E5C File Offset: 0x001A205C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					QuestsRequest._parser = new MessageParser<QuestsRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x001A3F54 File Offset: 0x001A2154
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zPCX8wOosIGoHpnEkIKN()
		{
			return true;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x001A3F5C File Offset: 0x001A215C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestsRequest Uy2cISOodgmqemLYASqg()
		{
			return null;
		}

		// Token: 0x040006DA RID: 1754
		private static readonly MessageParser<QuestsRequest> _parser;

		// Token: 0x040006DB RID: 1755
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006DC RID: 1756
		internal static QuestsRequest DBJtnkOoguVaNFrQdT8H;
	}
}
