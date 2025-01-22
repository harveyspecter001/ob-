using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x020004AB RID: 1195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Element : IMessage<Element>, IMessage, IEquatable<Element>, IDeepCloneable<Element>, IBufferMessage
	{
		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x001E14CC File Offset: 0x001DF6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Element> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x001E14DC File Offset: 0x001DF6DC
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

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x001E14EC File Offset: 0x001DF6EC
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

		// Token: 0x06003924 RID: 14628 RVA: 0x001E14FC File Offset: 0x001DF6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Element()
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x001E150C File Offset: 0x001DF70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Element(Element other)
		{
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x001E151C File Offset: 0x001DF71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Element Clone()
		{
			return null;
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x001E152C File Offset: 0x001DF72C
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x001E153C File Offset: 0x001DF73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellId
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

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x001E154C File Offset: 0x001DF74C
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x001E155C File Offset: 0x001DF75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ElementId
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

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x001E156C File Offset: 0x001DF76C
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x001E157C File Offset: 0x001DF77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Orientation
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

		// Token: 0x0600392D RID: 14637 RVA: 0x001E158C File Offset: 0x001DF78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x001E159C File Offset: 0x001DF79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Element other)
		{
			return true;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x001E15AC File Offset: 0x001DF7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x001E15BC File Offset: 0x001DF7BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x001E15CC File Offset: 0x001DF7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x001E15DC File Offset: 0x001DF7DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x001E15EC File Offset: 0x001DF7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x001E15FC File Offset: 0x001DF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Element other)
		{
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x001E160C File Offset: 0x001DF80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x001E161C File Offset: 0x001DF81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x001E162C File Offset: 0x001DF82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Element()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Element._parser = new MessageParser<Element>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x001E1710 File Offset: 0x001DF910
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yf5ir3OwFeJA5A14AIbK()
		{
			return true;
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x001E1718 File Offset: 0x001DF918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Element sI3iCUOwzAVKe0QpDCjf()
		{
			return null;
		}

		// Token: 0x040013EC RID: 5100
		private static readonly MessageParser<Element> _parser;

		// Token: 0x040013ED RID: 5101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013EE RID: 5102
		public const int CellIdFieldNumber = 1;

		// Token: 0x040013EF RID: 5103
		private int cellId_;

		// Token: 0x040013F0 RID: 5104
		public const int ElementIdFieldNumber = 2;

		// Token: 0x040013F1 RID: 5105
		private int elementId_;

		// Token: 0x040013F2 RID: 5106
		public const int OrientationFieldNumber = 3;

		// Token: 0x040013F3 RID: 5107
		private int orientation_;

		// Token: 0x040013F4 RID: 5108
		private static Element Gp9g4uOwq0ICdF8QNjaZ;
	}
}
