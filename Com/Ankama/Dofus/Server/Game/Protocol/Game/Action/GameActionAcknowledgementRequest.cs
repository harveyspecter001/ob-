using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005BF RID: 1471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionAcknowledgementRequest : IMessage<GameActionAcknowledgementRequest>, IMessage, IEquatable<GameActionAcknowledgementRequest>, IDeepCloneable<GameActionAcknowledgementRequest>, IBufferMessage
	{
		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x001FDBDC File Offset: 0x001FBDDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionAcknowledgementRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x001FDBEC File Offset: 0x001FBDEC
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x001FDBFC File Offset: 0x001FBDFC
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

		// Token: 0x060046EF RID: 18159 RVA: 0x001FDC0C File Offset: 0x001FBE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionAcknowledgementRequest()
		{
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x001FDC1C File Offset: 0x001FBE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionAcknowledgementRequest(GameActionAcknowledgementRequest other)
		{
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x001FDC2C File Offset: 0x001FBE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionAcknowledgementRequest Clone()
		{
			return null;
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x001FDC3C File Offset: 0x001FBE3C
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x001FDC4C File Offset: 0x001FBE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Valid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x001FDC5C File Offset: 0x001FBE5C
		// (set) Token: 0x060046F5 RID: 18165 RVA: 0x001FDC6C File Offset: 0x001FBE6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ActionId
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

		// Token: 0x060046F6 RID: 18166 RVA: 0x001FDC7C File Offset: 0x001FBE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x001FDC8C File Offset: 0x001FBE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionAcknowledgementRequest other)
		{
			return true;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x001FDC9C File Offset: 0x001FBE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x001FDCAC File Offset: 0x001FBEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001FDCBC File Offset: 0x001FBEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x001FDCCC File Offset: 0x001FBECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x001FDCDC File Offset: 0x001FBEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x001FDCEC File Offset: 0x001FBEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionAcknowledgementRequest other)
		{
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x001FDCFC File Offset: 0x001FBEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x001FDD0C File Offset: 0x001FBF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x001FDD1C File Offset: 0x001FBF1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionAcknowledgementRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				GameActionAcknowledgementRequest._parser = new MessageParser<GameActionAcknowledgementRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x001FDE00 File Offset: 0x001FC000
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ye56y2Obh1WsQSkyjAI5()
		{
			return true;
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x001FDE08 File Offset: 0x001FC008
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionAcknowledgementRequest DsjA6OObrhbxlplHrPiw()
		{
			return null;
		}

		// Token: 0x04001895 RID: 6293
		private static readonly MessageParser<GameActionAcknowledgementRequest> _parser;

		// Token: 0x04001896 RID: 6294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001897 RID: 6295
		public const int ValidFieldNumber = 1;

		// Token: 0x04001898 RID: 6296
		private bool valid_;

		// Token: 0x04001899 RID: 6297
		public const int ActionIdFieldNumber = 2;

		// Token: 0x0400189A RID: 6298
		private int actionId_;

		// Token: 0x0400189B RID: 6299
		private static GameActionAcknowledgementRequest fENbdQObWWoHrlLyFmtJ;
	}
}
