using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002AA RID: 682
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowDeactivationResponse : IMessage<AutoFollowDeactivationResponse>, IMessage, IEquatable<AutoFollowDeactivationResponse>, IDeepCloneable<AutoFollowDeactivationResponse>, IBufferMessage
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x001B93E8 File Offset: 0x001B75E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AutoFollowDeactivationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x001B93F8 File Offset: 0x001B75F8
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x001B9408 File Offset: 0x001B7608
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

		// Token: 0x06001FD8 RID: 8152 RVA: 0x001B9418 File Offset: 0x001B7618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationResponse()
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x001B9428 File Offset: 0x001B7628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationResponse(AutoFollowDeactivationResponse other)
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x001B9438 File Offset: 0x001B7638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowDeactivationResponse Clone()
		{
			return null;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x001B9448 File Offset: 0x001B7648
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x001B945C File Offset: 0x001B765C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AutoFollowDeactivationResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AutoFollowDeactivationResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x001B946C File Offset: 0x001B766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x001B947C File Offset: 0x001B767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowDeactivationResponse other)
		{
			return true;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x001B948C File Offset: 0x001B768C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x001B949C File Offset: 0x001B769C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x001B94AC File Offset: 0x001B76AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x001B94BC File Offset: 0x001B76BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x001B94CC File Offset: 0x001B76CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x001B94DC File Offset: 0x001B76DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowDeactivationResponse other)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x001B94EC File Offset: 0x001B76EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x001B94FC File Offset: 0x001B76FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x001B950C File Offset: 0x001B770C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowDeactivationResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AutoFollowDeactivationResponse._parser = new MessageParser<AutoFollowDeactivationResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x001B95D8 File Offset: 0x001B77D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vdk5X6O6mUVEEu9kqBGO()
		{
			return true;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x001B95E0 File Offset: 0x001B77E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowDeactivationResponse LNffcfO6A2DsvxOP3UrP()
		{
			return null;
		}

		// Token: 0x04000B32 RID: 2866
		private static readonly MessageParser<AutoFollowDeactivationResponse> _parser;

		// Token: 0x04000B33 RID: 2867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B34 RID: 2868
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B35 RID: 2869
		private AutoFollowDeactivationResponse.Types.Result result_;

		// Token: 0x04000B36 RID: 2870
		internal static AutoFollowDeactivationResponse ERnA6lO6ndl9cHr5Q0Wn;

		// Token: 0x020002AB RID: 683
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001FEA RID: 8170 RVA: 0x002B4350 File Offset: 0x002B2550
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002AC RID: 684
			public enum Result
			{
				// Token: 0x04000B38 RID: 2872
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B39 RID: 2873
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
