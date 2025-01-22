using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog
{
	// Token: 0x020007E2 RID: 2018
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DialogLeaveEvent : IMessage<DialogLeaveEvent>, IMessage, IEquatable<DialogLeaveEvent>, IDeepCloneable<DialogLeaveEvent>, IBufferMessage
	{
		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x002234E4 File Offset: 0x002216E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DialogLeaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x002234F4 File Offset: 0x002216F4
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

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060062A4 RID: 25252 RVA: 0x00223504 File Offset: 0x00221704
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

		// Token: 0x060062A5 RID: 25253 RVA: 0x00223514 File Offset: 0x00221714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveEvent()
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00223524 File Offset: 0x00221724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveEvent(DialogLeaveEvent other)
		{
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x00223534 File Offset: 0x00221734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveEvent Clone()
		{
			return null;
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060062A8 RID: 25256 RVA: 0x00223544 File Offset: 0x00221744
		// (set) Token: 0x060062A9 RID: 25257 RVA: 0x00223558 File Offset: 0x00221758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DialogType DialogType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DialogType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00223568 File Offset: 0x00221768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00223578 File Offset: 0x00221778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DialogLeaveEvent other)
		{
			return true;
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00223588 File Offset: 0x00221788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x00223598 File Offset: 0x00221798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x002235A8 File Offset: 0x002217A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x002235B8 File Offset: 0x002217B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x002235C8 File Offset: 0x002217C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x002235D8 File Offset: 0x002217D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DialogLeaveEvent other)
		{
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x002235E8 File Offset: 0x002217E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x002235F8 File Offset: 0x002217F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x00223608 File Offset: 0x00221808
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DialogLeaveEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_72;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					DialogLeaveEvent._parser = new MessageParser<DialogLeaveEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
					}
				}
				IL_72:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x002236D8 File Offset: 0x002218D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jph9yIOFHoCnqocSaJq2()
		{
			return true;
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x002236E0 File Offset: 0x002218E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogLeaveEvent wKgt5jOFY42E6wONfFux()
		{
			return null;
		}

		// Token: 0x040022AA RID: 8874
		private static readonly MessageParser<DialogLeaveEvent> _parser;

		// Token: 0x040022AB RID: 8875
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022AC RID: 8876
		public const int DialogTypeFieldNumber = 1;

		// Token: 0x040022AD RID: 8877
		private DialogType dialogType_;

		// Token: 0x040022AE RID: 8878
		internal static DialogLeaveEvent nQTg6hOFprXwrel2tQka;
	}
}
