using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008B9 RID: 2233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Choice : IMessage<Choice>, IMessage, IEquatable<Choice>, IDeepCloneable<Choice>, IBufferMessage
	{
		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x00233164 File Offset: 0x00231364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Choice> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x00233174 File Offset: 0x00231374
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x00233184 File Offset: 0x00231384
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

		// Token: 0x06006C73 RID: 27763 RVA: 0x00233194 File Offset: 0x00231394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Choice()
		{
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x002331A4 File Offset: 0x002313A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Choice(Choice other)
		{
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x002331B4 File Offset: 0x002313B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Choice Clone()
		{
			return null;
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06006C76 RID: 27766 RVA: 0x002331C4 File Offset: 0x002313C4
		// (set) Token: 0x06006C77 RID: 27767 RVA: 0x002331D4 File Offset: 0x002313D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06006C78 RID: 27768 RVA: 0x002331E4 File Offset: 0x002313E4
		// (set) Token: 0x06006C79 RID: 27769 RVA: 0x002331F4 File Offset: 0x002313F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Position
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

		// Token: 0x06006C7A RID: 27770 RVA: 0x00233204 File Offset: 0x00231404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x00233214 File Offset: 0x00231414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Choice other)
		{
			return true;
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x00233224 File Offset: 0x00231424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00233234 File Offset: 0x00231434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00233244 File Offset: 0x00231444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00233254 File Offset: 0x00231454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00233264 File Offset: 0x00231464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x00233274 File Offset: 0x00231474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Choice other)
		{
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x00233284 File Offset: 0x00231484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00233294 File Offset: 0x00231494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x002332A4 File Offset: 0x002314A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Choice()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Choice._parser = new MessageParser<Choice>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00233370 File Offset: 0x00231570
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C5JLM7JA3AEom97C0QQe()
		{
			return true;
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x00233378 File Offset: 0x00231578
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Choice sdmyMgJARgCGwvHsAwND()
		{
			return null;
		}

		// Token: 0x040025D0 RID: 9680
		private static readonly MessageParser<Choice> _parser;

		// Token: 0x040025D1 RID: 9681
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025D2 RID: 9682
		public const int IdFieldNumber = 1;

		// Token: 0x040025D3 RID: 9683
		private int id_;

		// Token: 0x040025D4 RID: 9684
		public const int PositionFieldNumber = 2;

		// Token: 0x040025D5 RID: 9685
		private int position_;

		// Token: 0x040025D6 RID: 9686
		private static Choice M58bx9JAeakVfBW4lfcF;
	}
}
