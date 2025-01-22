using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x020004A1 RID: 1185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagFurnitureEvent : IMessage<HavenBagFurnitureEvent>, IMessage, IEquatable<HavenBagFurnitureEvent>, IDeepCloneable<HavenBagFurnitureEvent>, IBufferMessage
	{
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x001E0A14 File Offset: 0x001DEC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagFurnitureEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x001E0A24 File Offset: 0x001DEC24
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

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x001E0A34 File Offset: 0x001DEC34
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

		// Token: 0x0600389F RID: 14495 RVA: 0x001E0A44 File Offset: 0x001DEC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureEvent()
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x001E0A54 File Offset: 0x001DEC54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureEvent(HavenBagFurnitureEvent other)
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x001E0A64 File Offset: 0x001DEC64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x001E0A74 File Offset: 0x001DEC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Element> Furniture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x001E0A84 File Offset: 0x001DEC84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x001E0A94 File Offset: 0x001DEC94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagFurnitureEvent other)
		{
			return true;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x001E0AA4 File Offset: 0x001DECA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x001E0AB4 File Offset: 0x001DECB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x001E0AC4 File Offset: 0x001DECC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x001E0AD4 File Offset: 0x001DECD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x001E0AE4 File Offset: 0x001DECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x001E0AF4 File Offset: 0x001DECF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagFurnitureEvent other)
		{
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x001E0B04 File Offset: 0x001DED04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x001E0B14 File Offset: 0x001DED14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x001E0B24 File Offset: 0x001DED24
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagFurnitureEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagFurnitureEvent._repeated_furniture_codec = FieldCodec.ForMessage<Element>(10U, m74H6HmG5VAhiQF5gXhT.XVInXhlssT(m74H6HmG5VAhiQF5gXhT.tmkmGyQW1DI));
					num2 = 5;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					HavenBagFurnitureEvent._parser = new MessageParser<HavenBagFurnitureEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x001E0C2C File Offset: 0x001DEE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l8tYSXOwQhuv58obII9S()
		{
			return true;
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x001E0C34 File Offset: 0x001DEE34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagFurnitureEvent VqwkOkOw7aObq41cNrjP()
		{
			return null;
		}

		// Token: 0x040013C4 RID: 5060
		private static readonly MessageParser<HavenBagFurnitureEvent> _parser;

		// Token: 0x040013C5 RID: 5061
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013C6 RID: 5062
		public const int FurnitureFieldNumber = 1;

		// Token: 0x040013C7 RID: 5063
		private static readonly FieldCodec<Element> _repeated_furniture_codec;

		// Token: 0x040013C8 RID: 5064
		private readonly RepeatedField<Element> furniture_;

		// Token: 0x040013C9 RID: 5065
		internal static HavenBagFurnitureEvent LWuejEOwwJ3RweqdeMJs;
	}
}
