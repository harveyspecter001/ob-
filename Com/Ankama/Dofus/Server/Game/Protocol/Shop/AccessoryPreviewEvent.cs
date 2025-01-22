using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop
{
	// Token: 0x02000160 RID: 352
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccessoryPreviewEvent : IMessage<AccessoryPreviewEvent>, IMessage, IEquatable<AccessoryPreviewEvent>, IDeepCloneable<AccessoryPreviewEvent>, IBufferMessage
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0019DC68 File Offset: 0x0019BE68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AccessoryPreviewEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0019DC78 File Offset: 0x0019BE78
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0019DC88 File Offset: 0x0019BE88
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

		// Token: 0x0600101D RID: 4125 RVA: 0x0019DC98 File Offset: 0x0019BE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewEvent()
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0019DCA8 File Offset: 0x0019BEA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewEvent(AccessoryPreviewEvent other)
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0019DCB8 File Offset: 0x0019BEB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewEvent Clone()
		{
			return null;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0019DCC8 File Offset: 0x0019BEC8
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x0019DCD8 File Offset: 0x0019BED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook Look
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0019DCE8 File Offset: 0x0019BEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0019DCF8 File Offset: 0x0019BEF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccessoryPreviewEvent other)
		{
			return true;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0019DD08 File Offset: 0x0019BF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0019DD18 File Offset: 0x0019BF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0019DD28 File Offset: 0x0019BF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0019DD38 File Offset: 0x0019BF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0019DD48 File Offset: 0x0019BF48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0019DD58 File Offset: 0x0019BF58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccessoryPreviewEvent other)
		{
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0019DD68 File Offset: 0x0019BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0019DD78 File Offset: 0x0019BF78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0019DD88 File Offset: 0x0019BF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccessoryPreviewEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AccessoryPreviewEvent._parser = new MessageParser<AccessoryPreviewEvent>(() => null);
						num2 = 4;
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_AC:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				goto IL_AC;
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0019DE58 File Offset: 0x0019C058
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mE2MXZOU7O26OSZUNPLL()
		{
			return true;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0019DE60 File Offset: 0x0019C060
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccessoryPreviewEvent PfaAUiOUT7x8qAJktM96()
		{
			return null;
		}

		// Token: 0x040005DF RID: 1503
		private static readonly MessageParser<AccessoryPreviewEvent> _parser;

		// Token: 0x040005E0 RID: 1504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005E1 RID: 1505
		public const int LookFieldNumber = 1;

		// Token: 0x040005E2 RID: 1506
		private EntityLook look_;

		// Token: 0x040005E3 RID: 1507
		internal static AccessoryPreviewEvent erFFvNOUQtMGVK8XPpLf;
	}
}
