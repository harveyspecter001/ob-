using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008DE RID: 2270
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChannelUpdateEvent : IMessage<ChannelUpdateEvent>, IMessage, IEquatable<ChannelUpdateEvent>, IDeepCloneable<ChannelUpdateEvent>, IBufferMessage
	{
		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x00236574 File Offset: 0x00234774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChannelUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06006E4D RID: 28237 RVA: 0x00236584 File Offset: 0x00234784
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x00236594 File Offset: 0x00234794
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

		// Token: 0x06006E4F RID: 28239 RVA: 0x002365A4 File Offset: 0x002347A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChannelUpdateEvent()
		{
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x002365B4 File Offset: 0x002347B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChannelUpdateEvent(ChannelUpdateEvent other)
		{
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x002365C4 File Offset: 0x002347C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChannelUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x002365D4 File Offset: 0x002347D4
		// (set) Token: 0x06006E53 RID: 28243 RVA: 0x002365E8 File Offset: 0x002347E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Channel Channel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Channel)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x002365F8 File Offset: 0x002347F8
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x00236608 File Offset: 0x00234808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
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

		// Token: 0x06006E56 RID: 28246 RVA: 0x00236618 File Offset: 0x00234818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x00236628 File Offset: 0x00234828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChannelUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00236638 File Offset: 0x00234838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00236648 File Offset: 0x00234848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00236658 File Offset: 0x00234858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x00236668 File Offset: 0x00234868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x00236678 File Offset: 0x00234878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00236688 File Offset: 0x00234888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChannelUpdateEvent other)
		{
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x00236698 File Offset: 0x00234898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x002366A8 File Offset: 0x002348A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x002366B8 File Offset: 0x002348B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChannelUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				ChannelUpdateEvent._parser = new MessageParser<ChannelUpdateEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x00236784 File Offset: 0x00234984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool STQR8YJAFdBfPRMr8QDh()
		{
			return true;
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x0023678C File Offset: 0x0023498C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChannelUpdateEvent uD5rQUJAzwRfgDpWLDCQ()
		{
			return null;
		}

		// Token: 0x040026A8 RID: 9896
		private static readonly MessageParser<ChannelUpdateEvent> _parser;

		// Token: 0x040026A9 RID: 9897
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026AA RID: 9898
		public const int ChannelFieldNumber = 1;

		// Token: 0x040026AB RID: 9899
		private Channel channel_;

		// Token: 0x040026AC RID: 9900
		public const int EnableFieldNumber = 2;

		// Token: 0x040026AD RID: 9901
		private bool enable_;

		// Token: 0x040026AE RID: 9902
		private static ChannelUpdateEvent zYNv88JAqRMtb0TUYMvB;
	}
}
