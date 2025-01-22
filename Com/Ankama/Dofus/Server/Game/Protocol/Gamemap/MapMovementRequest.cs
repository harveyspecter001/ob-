using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000574 RID: 1396
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapMovementRequest : IMessage<MapMovementRequest>, IMessage, IEquatable<MapMovementRequest>, IDeepCloneable<MapMovementRequest>, IBufferMessage
	{
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x001F4B04 File Offset: 0x001F2D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapMovementRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x001F4B14 File Offset: 0x001F2D14
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x001F4B24 File Offset: 0x001F2D24
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

		// Token: 0x06004331 RID: 17201 RVA: 0x001F4B34 File Offset: 0x001F2D34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRequest()
		{
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x001F4B44 File Offset: 0x001F2D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRequest(MapMovementRequest other)
		{
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x001F4B54 File Offset: 0x001F2D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x001F4B64 File Offset: 0x001F2D64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> KeyCells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x001F4B74 File Offset: 0x001F2D74
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x001F4B84 File Offset: 0x001F2D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x001F4B94 File Offset: 0x001F2D94
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x001F4BA4 File Offset: 0x001F2DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Cautious
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

		// Token: 0x06004339 RID: 17209 RVA: 0x001F4BB4 File Offset: 0x001F2DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x001F4BC4 File Offset: 0x001F2DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapMovementRequest other)
		{
			return true;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x001F4BD4 File Offset: 0x001F2DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x001F4BE4 File Offset: 0x001F2DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001F4BF4 File Offset: 0x001F2DF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x001F4C04 File Offset: 0x001F2E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x001F4C14 File Offset: 0x001F2E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x001F4C24 File Offset: 0x001F2E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapMovementRequest other)
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x001F4C34 File Offset: 0x001F2E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x001F4C44 File Offset: 0x001F2E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001F4C54 File Offset: 0x001F2E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapMovementRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MapMovementRequest._parser = new MessageParser<MapMovementRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				MapMovementRequest._repeated_keyCells_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 5;
			}
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x001F4D6C File Offset: 0x001F2F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OaNnikOHYOxnmc716fgP()
		{
			return true;
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x001F4D74 File Offset: 0x001F2F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapMovementRequest RfXSQuOHbcSgFvB8WKd9()
		{
			return null;
		}

		// Token: 0x04001729 RID: 5929
		private static readonly MessageParser<MapMovementRequest> _parser;

		// Token: 0x0400172A RID: 5930
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400172B RID: 5931
		public const int KeyCellsFieldNumber = 1;

		// Token: 0x0400172C RID: 5932
		private static readonly FieldCodec<int> _repeated_keyCells_codec;

		// Token: 0x0400172D RID: 5933
		private readonly RepeatedField<int> keyCells_;

		// Token: 0x0400172E RID: 5934
		public const int MapIdFieldNumber = 2;

		// Token: 0x0400172F RID: 5935
		private long mapId_;

		// Token: 0x04001730 RID: 5936
		public const int CautiousFieldNumber = 3;

		// Token: 0x04001731 RID: 5937
		private bool cautious_;

		// Token: 0x04001732 RID: 5938
		internal static MapMovementRequest hsqcuEOHHKWfS9Bgdpll;
	}
}
