using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002AE RID: 686
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowDeactivatedEvent : IMessage<AutoFollowDeactivatedEvent>, IMessage, IEquatable<AutoFollowDeactivatedEvent>, IDeepCloneable<AutoFollowDeactivatedEvent>, IBufferMessage
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x001B95E8 File Offset: 0x001B77E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AutoFollowDeactivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x001B95F8 File Offset: 0x001B77F8
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x001B9608 File Offset: 0x001B7808
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

		// Token: 0x06001FF3 RID: 8179 RVA: 0x001B9618 File Offset: 0x001B7818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivatedEvent()
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x001B9628 File Offset: 0x001B7828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivatedEvent(AutoFollowDeactivatedEvent other)
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x001B9638 File Offset: 0x001B7838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x001B9648 File Offset: 0x001B7848
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x001B9658 File Offset: 0x001B7858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06001FF8 RID: 8184 RVA: 0x001B9668 File Offset: 0x001B7868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x001B9678 File Offset: 0x001B7878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowDeactivatedEvent other)
		{
			return true;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x001B9688 File Offset: 0x001B7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x001B9698 File Offset: 0x001B7898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x001B96A8 File Offset: 0x001B78A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x001B96B8 File Offset: 0x001B78B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x001B96C8 File Offset: 0x001B78C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x001B96D8 File Offset: 0x001B78D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowDeactivatedEvent other)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x001B96E8 File Offset: 0x001B78E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x001B96F8 File Offset: 0x001B78F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x001B9708 File Offset: 0x001B7908
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowDeactivatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AutoFollowDeactivatedEvent._parser = new MessageParser<AutoFollowDeactivatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x001B97D4 File Offset: 0x001B79D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YiPwXOO6eX8wBw7nOJXb()
		{
			return true;
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x001B97DC File Offset: 0x001B79DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowDeactivatedEvent epLus9O63P9VQVm4nL14()
		{
			return null;
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly MessageParser<AutoFollowDeactivatedEvent> _parser;

		// Token: 0x04000B3D RID: 2877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B3E RID: 2878
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B3F RID: 2879
		private long playerId_;

		// Token: 0x04000B40 RID: 2880
		internal static AutoFollowDeactivatedEvent WVrE4iO6B5k1Iw1hG57k;
	}
}
