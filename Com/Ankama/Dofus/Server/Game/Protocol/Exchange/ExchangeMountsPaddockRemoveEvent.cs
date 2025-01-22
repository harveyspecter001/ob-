using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000791 RID: 1937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountsPaddockRemoveEvent : IMessage<ExchangeMountsPaddockRemoveEvent>, IMessage, IEquatable<ExchangeMountsPaddockRemoveEvent>, IDeepCloneable<ExchangeMountsPaddockRemoveEvent>, IBufferMessage
	{
		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x0021DF60 File Offset: 0x0021C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMountsPaddockRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x0021DF70 File Offset: 0x0021C170
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06005F02 RID: 24322 RVA: 0x0021DF80 File Offset: 0x0021C180
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

		// Token: 0x06005F03 RID: 24323 RVA: 0x0021DF90 File Offset: 0x0021C190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockRemoveEvent()
		{
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0021DFA0 File Offset: 0x0021C1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockRemoveEvent(ExchangeMountsPaddockRemoveEvent other)
		{
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x0021DFB0 File Offset: 0x0021C1B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsPaddockRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06005F06 RID: 24326 RVA: 0x0021DFC0 File Offset: 0x0021C1C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> MountsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x0021DFD0 File Offset: 0x0021C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x0021DFE0 File Offset: 0x0021C1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountsPaddockRemoveEvent other)
		{
			return true;
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x0021DFF0 File Offset: 0x0021C1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0021E000 File Offset: 0x0021C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x0021E010 File Offset: 0x0021C210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0021E020 File Offset: 0x0021C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0021E030 File Offset: 0x0021C230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x0021E040 File Offset: 0x0021C240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountsPaddockRemoveEvent other)
		{
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0021E050 File Offset: 0x0021C250
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x0021E060 File Offset: 0x0021C260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x0021E070 File Offset: 0x0021C270
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountsPaddockRemoveEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_A6;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
						{
							num2 = 1;
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
					case 5:
						ExchangeMountsPaddockRemoveEvent._repeated_mountsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_A6:
				ExchangeMountsPaddockRemoveEvent._parser = new MessageParser<ExchangeMountsPaddockRemoveEvent>(() => null);
				num = 5;
			}
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0021E160 File Offset: 0x0021C360
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E1DeVROqJO1JL1N4luwB()
		{
			return true;
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x0021E168 File Offset: 0x0021C368
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountsPaddockRemoveEvent thRJKtOqGufV2GffhsrJ()
		{
			return null;
		}

		// Token: 0x04002169 RID: 8553
		private static readonly MessageParser<ExchangeMountsPaddockRemoveEvent> _parser;

		// Token: 0x0400216A RID: 8554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400216B RID: 8555
		public const int MountsIdFieldNumber = 1;

		// Token: 0x0400216C RID: 8556
		private static readonly FieldCodec<int> _repeated_mountsId_codec;

		// Token: 0x0400216D RID: 8557
		private readonly RepeatedField<int> mountsId_;

		// Token: 0x0400216E RID: 8558
		private static ExchangeMountsPaddockRemoveEvent PqYfldOqOwuRcrev1qED;
	}
}
