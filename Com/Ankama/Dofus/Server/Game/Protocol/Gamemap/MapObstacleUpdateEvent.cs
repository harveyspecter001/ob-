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
	// Token: 0x0200059C RID: 1436
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapObstacleUpdateEvent : IMessage<MapObstacleUpdateEvent>, IMessage, IEquatable<MapObstacleUpdateEvent>, IDeepCloneable<MapObstacleUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x001F7738 File Offset: 0x001F5938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapObstacleUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x001F7748 File Offset: 0x001F5948
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x001F7758 File Offset: 0x001F5958
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

		// Token: 0x0600454B RID: 17739 RVA: 0x001F7768 File Offset: 0x001F5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacleUpdateEvent()
		{
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001F7778 File Offset: 0x001F5978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacleUpdateEvent(MapObstacleUpdateEvent other)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x001F7788 File Offset: 0x001F5988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapObstacleUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x001F7798 File Offset: 0x001F5998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapObstacle> Obstacles
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x001F77A8 File Offset: 0x001F59A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x001F77B8 File Offset: 0x001F59B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapObstacleUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x001F77C8 File Offset: 0x001F59C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x001F77D8 File Offset: 0x001F59D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x001F77E8 File Offset: 0x001F59E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x001F77F8 File Offset: 0x001F59F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x001F7808 File Offset: 0x001F5A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001F7818 File Offset: 0x001F5A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapObstacleUpdateEvent other)
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x001F7828 File Offset: 0x001F5A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x001F7838 File Offset: 0x001F5A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x001F7848 File Offset: 0x001F5A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapObstacleUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MapObstacleUpdateEvent._repeated_obstacles_codec = FieldCodec.ForMessage<MapObstacle>(10U, wKWZk1mh5EAemHwVlZcf.XVInXhlssT(wKWZk1mh5EAemHwVlZcf.c74mhyuKkiw));
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					MapObstacleUpdateEvent._parser = new MessageParser<MapObstacleUpdateEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001F7950 File Offset: 0x001F5B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NPIcu2OYpfEH7WQm3qyh()
		{
			return true;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x001F7958 File Offset: 0x001F5B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapObstacleUpdateEvent UslcwDOYH6rSbKSbEGrk()
		{
			return null;
		}

		// Token: 0x040017D7 RID: 6103
		private static readonly MessageParser<MapObstacleUpdateEvent> _parser;

		// Token: 0x040017D8 RID: 6104
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017D9 RID: 6105
		public const int ObstaclesFieldNumber = 1;

		// Token: 0x040017DA RID: 6106
		private static readonly FieldCodec<MapObstacle> _repeated_obstacles_codec;

		// Token: 0x040017DB RID: 6107
		private readonly RepeatedField<MapObstacle> obstacles_;

		// Token: 0x040017DC RID: 6108
		internal static MapObstacleUpdateEvent HD28rhOYTBtNxljL6iRT;
	}
}
