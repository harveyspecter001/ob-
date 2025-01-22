using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x020005B0 RID: 1456
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapObstacle : IMessage<MapObstacle>, IMessage, IEquatable<MapObstacle>, IDeepCloneable<MapObstacle>, IBufferMessage
	{
		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x001F8E24 File Offset: 0x001F7024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapObstacle> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x001F8E34 File Offset: 0x001F7034
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

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x001F8E44 File Offset: 0x001F7044
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

		// Token: 0x06004660 RID: 18016 RVA: 0x001F8E54 File Offset: 0x001F7054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacle()
		{
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x001F8E64 File Offset: 0x001F7064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacle(MapObstacle other)
		{
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x001F8E74 File Offset: 0x001F7074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacle Clone()
		{
			return null;
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x001F8E84 File Offset: 0x001F7084
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x001F8E94 File Offset: 0x001F7094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
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

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x001F8EA4 File Offset: 0x001F70A4
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x001F8EB8 File Offset: 0x001F70B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapObstacle.Types.ObstacleState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MapObstacle.Types.ObstacleState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x001F8EC8 File Offset: 0x001F70C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x001F8ED8 File Offset: 0x001F70D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapObstacle other)
		{
			return true;
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x001F8EE8 File Offset: 0x001F70E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x001F8EF8 File Offset: 0x001F70F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x001F8F08 File Offset: 0x001F7108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x001F8F18 File Offset: 0x001F7118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x001F8F28 File Offset: 0x001F7128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x001F8F38 File Offset: 0x001F7138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapObstacle other)
		{
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x001F8F48 File Offset: 0x001F7148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x001F8F58 File Offset: 0x001F7158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x001F8F68 File Offset: 0x001F7168
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapObstacle()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				MapObstacle._parser = new MessageParser<MapObstacle>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x001F904C File Offset: 0x001F724C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BxQPSNObdpOIbNkvNbMb()
		{
			return true;
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x001F9054 File Offset: 0x001F7254
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapObstacle CnH7T0Ob9IefoIy8hgCr()
		{
			return null;
		}

		// Token: 0x04001857 RID: 6231
		private static readonly MessageParser<MapObstacle> _parser;

		// Token: 0x04001858 RID: 6232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001859 RID: 6233
		public const int CellIdFieldNumber = 1;

		// Token: 0x0400185A RID: 6234
		private int cellId_;

		// Token: 0x0400185B RID: 6235
		public const int StateFieldNumber = 2;

		// Token: 0x0400185C RID: 6236
		private MapObstacle.Types.ObstacleState state_;

		// Token: 0x0400185D RID: 6237
		private static MapObstacle ncjlQ2ObspKAJAxW2xbc;

		// Token: 0x020005B1 RID: 1457
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06004674 RID: 18036 RVA: 0x002C85F4 File Offset: 0x002C67F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020005B2 RID: 1458
			public enum ObstacleState
			{
				// Token: 0x0400185F RID: 6239
				[OriginalName("OBSTACLE_OPENED")]
				ObstacleOpened,
				// Token: 0x04001860 RID: 6240
				[OriginalName("OBSTACLE_CLOSED")]
				ObstacleClosed
			}
		}
	}
}
