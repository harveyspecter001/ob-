using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CAB RID: 3243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipTitleResponse : IMessage<OutfitEquipTitleResponse>, IMessage, IEquatable<OutfitEquipTitleResponse>, IDeepCloneable<OutfitEquipTitleResponse>, IBufferMessage
	{
		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x00280968 File Offset: 0x0027EB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipTitleResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x00280978 File Offset: 0x0027EB78
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

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x00280988 File Offset: 0x0027EB88
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

		// Token: 0x06009BC5 RID: 39877 RVA: 0x00280998 File Offset: 0x0027EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleResponse()
		{
		}

		// Token: 0x06009BC6 RID: 39878 RVA: 0x002809A8 File Offset: 0x0027EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleResponse(OutfitEquipTitleResponse other)
		{
		}

		// Token: 0x06009BC7 RID: 39879 RVA: 0x002809B8 File Offset: 0x0027EBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipTitleResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06009BC8 RID: 39880 RVA: 0x002809C8 File Offset: 0x0027EBC8
		// (set) Token: 0x06009BC9 RID: 39881 RVA: 0x002809D8 File Offset: 0x0027EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x002809E8 File Offset: 0x0027EBE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x002809F8 File Offset: 0x0027EBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipTitleResponse other)
		{
			return true;
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x00280A08 File Offset: 0x0027EC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00280A18 File Offset: 0x0027EC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x00280A28 File Offset: 0x0027EC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x00280A38 File Offset: 0x0027EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x00280A48 File Offset: 0x0027EC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x00280A58 File Offset: 0x0027EC58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipTitleResponse other)
		{
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x00280A68 File Offset: 0x0027EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x00280A78 File Offset: 0x0027EC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x00280A88 File Offset: 0x0027EC88
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipTitleResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				OutfitEquipTitleResponse._parser = new MessageParser<OutfitEquipTitleResponse>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x00280B54 File Offset: 0x0027ED54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ctrfLIJxZh8hmi13cYJx()
		{
			return true;
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x00280B5C File Offset: 0x0027ED5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipTitleResponse hTWrVbJxqo9wbrnFh1nv()
		{
			return null;
		}

		// Token: 0x040039CC RID: 14796
		private static readonly MessageParser<OutfitEquipTitleResponse> _parser;

		// Token: 0x040039CD RID: 14797
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039CE RID: 14798
		public const int SuccessFieldNumber = 1;

		// Token: 0x040039CF RID: 14799
		private bool success_;

		// Token: 0x040039D0 RID: 14800
		internal static OutfitEquipTitleResponse r4C4EDJx8ubM3JAOKBrh;
	}
}
