using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020007A7 RID: 1959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectAveragePricesErrorEvent : IMessage<ObjectAveragePricesErrorEvent>, IMessage, IEquatable<ObjectAveragePricesErrorEvent>, IDeepCloneable<ObjectAveragePricesErrorEvent>, IBufferMessage
	{
		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06006017 RID: 24599 RVA: 0x0021F5A8 File Offset: 0x0021D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectAveragePricesErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x0021F5B8 File Offset: 0x0021D7B8
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

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x0021F5C8 File Offset: 0x0021D7C8
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

		// Token: 0x0600601A RID: 24602 RVA: 0x0021F5D8 File Offset: 0x0021D7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesErrorEvent()
		{
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x0021F5E8 File Offset: 0x0021D7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesErrorEvent(ObjectAveragePricesErrorEvent other)
		{
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x0021F5F8 File Offset: 0x0021D7F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x0021F608 File Offset: 0x0021D808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x0021F618 File Offset: 0x0021D818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectAveragePricesErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x0021F628 File Offset: 0x0021D828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x0021F638 File Offset: 0x0021D838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x0021F648 File Offset: 0x0021D848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x0021F658 File Offset: 0x0021D858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x0021F668 File Offset: 0x0021D868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x0021F678 File Offset: 0x0021D878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectAveragePricesErrorEvent other)
		{
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x0021F688 File Offset: 0x0021D888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x0021F698 File Offset: 0x0021D898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x0021F6A8 File Offset: 0x0021D8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectAveragePricesErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ObjectAveragePricesErrorEvent._parser = new MessageParser<ObjectAveragePricesErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0021F774 File Offset: 0x0021D974
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wcJbpuOqVK3M07RHwfUS()
		{
			return true;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0021F77C File Offset: 0x0021D97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectAveragePricesErrorEvent Ft18yWOq0f3NuFd1OgHV()
		{
			return null;
		}

		// Token: 0x040021CE RID: 8654
		private static readonly MessageParser<ObjectAveragePricesErrorEvent> _parser;

		// Token: 0x040021CF RID: 8655
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021D0 RID: 8656
		internal static ObjectAveragePricesErrorEvent apotXtOqrMemFH6JPiMW;
	}
}
