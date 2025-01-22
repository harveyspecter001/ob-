using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B6E RID: 2926
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionItem : IMessage<GameActionItem>, IMessage, IEquatable<GameActionItem>, IDeepCloneable<GameActionItem>, IBufferMessage
	{
		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x002695C4 File Offset: 0x002677C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GameActionItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06008C54 RID: 35924 RVA: 0x002695D4 File Offset: 0x002677D4
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

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06008C55 RID: 35925 RVA: 0x002695E4 File Offset: 0x002677E4
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

		// Token: 0x06008C56 RID: 35926 RVA: 0x002695F4 File Offset: 0x002677F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItem()
		{
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00269604 File Offset: 0x00267804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItem(GameActionItem other)
		{
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00269614 File Offset: 0x00267814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionItem Clone()
		{
			return null;
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06008C59 RID: 35929 RVA: 0x00269624 File Offset: 0x00267824
		// (set) Token: 0x06008C5A RID: 35930 RVA: 0x00269634 File Offset: 0x00267834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06008C5B RID: 35931 RVA: 0x00269644 File Offset: 0x00267844
		// (set) Token: 0x06008C5C RID: 35932 RVA: 0x00269654 File Offset: 0x00267854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Title
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

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06008C5D RID: 35933 RVA: 0x00269664 File Offset: 0x00267864
		// (set) Token: 0x06008C5E RID: 35934 RVA: 0x00269674 File Offset: 0x00267874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Text
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

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06008C5F RID: 35935 RVA: 0x00269684 File Offset: 0x00267884
		// (set) Token: 0x06008C60 RID: 35936 RVA: 0x00269694 File Offset: 0x00267894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string DescUrl
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

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06008C61 RID: 35937 RVA: 0x002696A4 File Offset: 0x002678A4
		// (set) Token: 0x06008C62 RID: 35938 RVA: 0x002696B4 File Offset: 0x002678B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PictureUrl
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

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06008C63 RID: 35939 RVA: 0x002696C4 File Offset: 0x002678C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ItemMinimalInformation> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x002696D4 File Offset: 0x002678D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x002696E4 File Offset: 0x002678E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionItem other)
		{
			return true;
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x002696F4 File Offset: 0x002678F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x00269704 File Offset: 0x00267904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x00269714 File Offset: 0x00267914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x00269724 File Offset: 0x00267924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x00269734 File Offset: 0x00267934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x00269744 File Offset: 0x00267944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionItem other)
		{
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x00269754 File Offset: 0x00267954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00269764 File Offset: 0x00267964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x00269774 File Offset: 0x00267974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionItem()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						GameActionItem._repeated_items_codec = FieldCodec.ForMessage<ItemMinimalInformation>(50U, RUqVfFA15E2LoJALhA1Z.XVInXhlssT(RUqVfFA15E2LoJALhA1Z.xLMA1ySOq5M));
						num2 = 3;
						continue;
					case 5:
						goto IL_59;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
				}
				IL_59:
				GameActionItem._parser = new MessageParser<GameActionItem>(() => null);
				num = 4;
			}
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x00269868 File Offset: 0x00267A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V4aZOYJ9OhIwNS8G0y4k()
		{
			return true;
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x00269870 File Offset: 0x00267A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionItem bGCEVVJ9JSlO1liv8iqM()
		{
			return null;
		}

		// Token: 0x040033D6 RID: 13270
		private static readonly MessageParser<GameActionItem> _parser;

		// Token: 0x040033D7 RID: 13271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D8 RID: 13272
		public const int IdFieldNumber = 1;

		// Token: 0x040033D9 RID: 13273
		private int id_;

		// Token: 0x040033DA RID: 13274
		public const int TitleFieldNumber = 2;

		// Token: 0x040033DB RID: 13275
		private string title_;

		// Token: 0x040033DC RID: 13276
		public const int TextFieldNumber = 3;

		// Token: 0x040033DD RID: 13277
		private string text_;

		// Token: 0x040033DE RID: 13278
		public const int DescUrlFieldNumber = 4;

		// Token: 0x040033DF RID: 13279
		private string descUrl_;

		// Token: 0x040033E0 RID: 13280
		public const int PictureUrlFieldNumber = 5;

		// Token: 0x040033E1 RID: 13281
		private string pictureUrl_;

		// Token: 0x040033E2 RID: 13282
		public const int ItemsFieldNumber = 6;

		// Token: 0x040033E3 RID: 13283
		private static readonly FieldCodec<ItemMinimalInformation> _repeated_items_codec;

		// Token: 0x040033E4 RID: 13284
		private readonly RepeatedField<ItemMinimalInformation> items_;

		// Token: 0x040033E5 RID: 13285
		internal static GameActionItem ITbppSJ9RK5obD14Oo9g;
	}
}
