using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000596 RID: 1430
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightsEvent : IMessage<MapRunningFightsEvent>, IMessage, IEquatable<MapRunningFightsEvent>, IDeepCloneable<MapRunningFightsEvent>, IBufferMessage
	{
		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x001F6FD0 File Offset: 0x001F51D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapRunningFightsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x001F6FE0 File Offset: 0x001F51E0
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

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x001F6FF0 File Offset: 0x001F51F0
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

		// Token: 0x060044F9 RID: 17657 RVA: 0x001F7000 File Offset: 0x001F5200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsEvent()
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001F7010 File Offset: 0x001F5210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsEvent(MapRunningFightsEvent other)
		{
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x001F7020 File Offset: 0x001F5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x001F7030 File Offset: 0x001F5230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightExternalInformation> Fights
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x001F7040 File Offset: 0x001F5240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x001F7050 File Offset: 0x001F5250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightsEvent other)
		{
			return true;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x001F7060 File Offset: 0x001F5260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x001F7070 File Offset: 0x001F5270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x001F7080 File Offset: 0x001F5280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x001F7090 File Offset: 0x001F5290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x001F70A0 File Offset: 0x001F52A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x001F70B0 File Offset: 0x001F52B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightsEvent other)
		{
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x001F70C0 File Offset: 0x001F52C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x001F70D0 File Offset: 0x001F52D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x001F70E0 File Offset: 0x001F52E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					MapRunningFightsEvent._parser = new MessageParser<MapRunningFightsEvent>(() => null);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					MapRunningFightsEvent._repeated_fights_codec = FieldCodec.ForMessage<FightExternalInformation>(10U, dhbYV8m0ZAUWXrPe5eXe.XVInXhlssT(dhbYV8m0ZAUWXrPe5eXe.jj0m0q9sVWR));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x001F71E8 File Offset: 0x001F53E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j5uPdgOYVbh36mFBosQw()
		{
			return true;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x001F71F0 File Offset: 0x001F53F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightsEvent YtZRccOY0gKyZ2DvVGIu()
		{
			return null;
		}

		// Token: 0x040017B2 RID: 6066
		private static readonly MessageParser<MapRunningFightsEvent> _parser;

		// Token: 0x040017B3 RID: 6067
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017B4 RID: 6068
		public const int FightsFieldNumber = 1;

		// Token: 0x040017B5 RID: 6069
		private static readonly FieldCodec<FightExternalInformation> _repeated_fights_codec;

		// Token: 0x040017B6 RID: 6070
		private readonly RepeatedField<FightExternalInformation> fights_;

		// Token: 0x040017B7 RID: 6071
		internal static MapRunningFightsEvent G61RFROYrPINnwFqOCTi;
	}
}
