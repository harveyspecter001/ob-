using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000815 RID: 2069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextRemoveElementsEvent : IMessage<ContextRemoveElementsEvent>, IMessage, IEquatable<ContextRemoveElementsEvent>, IDeepCloneable<ContextRemoveElementsEvent>, IBufferMessage
	{
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00226E1C File Offset: 0x0022501C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ContextRemoveElementsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x00226E2C File Offset: 0x0022502C
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

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00226E3C File Offset: 0x0022503C
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

		// Token: 0x060064A6 RID: 25766 RVA: 0x00226E4C File Offset: 0x0022504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementsEvent()
		{
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00226E5C File Offset: 0x0022505C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementsEvent(ContextRemoveElementsEvent other)
		{
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00226E6C File Offset: 0x0022506C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRemoveElementsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x00226E7C File Offset: 0x0022507C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> ElementId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00226E8C File Offset: 0x0022508C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x00226E9C File Offset: 0x0022509C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextRemoveElementsEvent other)
		{
			return true;
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x00226EAC File Offset: 0x002250AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00226EBC File Offset: 0x002250BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x00226ECC File Offset: 0x002250CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00226EDC File Offset: 0x002250DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00226EEC File Offset: 0x002250EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00226EFC File Offset: 0x002250FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextRemoveElementsEvent other)
		{
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00226F0C File Offset: 0x0022510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00226F1C File Offset: 0x0022511C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00226F2C File Offset: 0x0022512C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextRemoveElementsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 3:
					return;
				case 4:
					ContextRemoveElementsEvent._repeated_elementId_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					ContextRemoveElementsEvent._parser = new MessageParser<ContextRemoveElementsEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00227044 File Offset: 0x00225244
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w8isPnOzYC0TZ352G6kh()
		{
			return true;
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x0022704C File Offset: 0x0022524C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextRemoveElementsEvent dNE9w8OzbQhjrjPK9Z0W()
		{
			return null;
		}

		// Token: 0x04002358 RID: 9048
		private static readonly MessageParser<ContextRemoveElementsEvent> _parser;

		// Token: 0x04002359 RID: 9049
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400235A RID: 9050
		public const int ElementIdFieldNumber = 1;

		// Token: 0x0400235B RID: 9051
		private static readonly FieldCodec<long> _repeated_elementId_codec;

		// Token: 0x0400235C RID: 9052
		private readonly RepeatedField<long> elementId_;

		// Token: 0x0400235D RID: 9053
		private static ContextRemoveElementsEvent NtGNFHOzHLNvOZB3tk2K;
	}
}
