using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000E8 RID: 232
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddTagObjectRequest : IMessage<AddTagObjectRequest>, IMessage, IEquatable<AddTagObjectRequest>, IDeepCloneable<AddTagObjectRequest>, IBufferMessage
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00194318 File Offset: 0x00192518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AddTagObjectRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00194328 File Offset: 0x00192528
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00194338 File Offset: 0x00192538
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

		// Token: 0x06000A77 RID: 2679 RVA: 0x00194348 File Offset: 0x00192548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectRequest()
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00194358 File Offset: 0x00192558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectRequest(AddTagObjectRequest other)
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00194368 File Offset: 0x00192568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagObjectRequest Clone()
		{
			return null;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00194378 File Offset: 0x00192578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TagObjectUpdateContent> TagObjectUpdateContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00194388 File Offset: 0x00192588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00194398 File Offset: 0x00192598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AddTagObjectRequest other)
		{
			return true;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x001943A8 File Offset: 0x001925A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x001943B8 File Offset: 0x001925B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x001943C8 File Offset: 0x001925C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x001943D8 File Offset: 0x001925D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x001943E8 File Offset: 0x001925E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x001943F8 File Offset: 0x001925F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AddTagObjectRequest other)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00194408 File Offset: 0x00192608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00194418 File Offset: 0x00192618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00194428 File Offset: 0x00192628
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddTagObjectRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AddTagObjectRequest._parser = new MessageParser<AddTagObjectRequest>(() => null);
					num2 = 3;
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AddTagObjectRequest._repeated_tagObjectUpdateContent_codec = FieldCodec.ForMessage<TagObjectUpdateContent>(10U, C0EwKkouUZnBXceLuXD.XVInXhlssT(C0EwKkouUZnBXceLuXD.GcYo8ERmhW));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00194544 File Offset: 0x00192744
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fj7ySOOleVrSdggut2is()
		{
			return true;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0019454C File Offset: 0x0019274C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AddTagObjectRequest ByNKCZOl34BsAQUXupdB()
		{
			return null;
		}

		// Token: 0x040003DA RID: 986
		private static readonly MessageParser<AddTagObjectRequest> _parser;

		// Token: 0x040003DB RID: 987
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003DC RID: 988
		public const int TagObjectUpdateContentFieldNumber = 1;

		// Token: 0x040003DD RID: 989
		private static readonly FieldCodec<TagObjectUpdateContent> _repeated_tagObjectUpdateContent_codec;

		// Token: 0x040003DE RID: 990
		private readonly RepeatedField<TagObjectUpdateContent> tagObjectUpdateContent_;

		// Token: 0x040003DF RID: 991
		internal static AddTagObjectRequest KXTqEgOlB5iBGZo28tVP;
	}
}
