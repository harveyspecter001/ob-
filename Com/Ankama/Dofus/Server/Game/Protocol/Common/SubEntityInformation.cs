using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A7F RID: 2687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubEntityInformation : IMessage<SubEntityInformation>, IMessage, IEquatable<SubEntityInformation>, IDeepCloneable<SubEntityInformation>, IBufferMessage
	{
		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x0600805A RID: 32858 RVA: 0x0025FCE0 File Offset: 0x0025DEE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SubEntityInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600805B RID: 32859 RVA: 0x0025FCF0 File Offset: 0x0025DEF0
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

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600805C RID: 32860 RVA: 0x0025FD00 File Offset: 0x0025DF00
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

		// Token: 0x0600805D RID: 32861 RVA: 0x0025FD10 File Offset: 0x0025DF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubEntityInformation()
		{
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x0025FD20 File Offset: 0x0025DF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubEntityInformation(SubEntityInformation other)
		{
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x0025FD30 File Offset: 0x0025DF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubEntityInformation Clone()
		{
			return null;
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06008060 RID: 32864 RVA: 0x0025FD40 File Offset: 0x0025DF40
		// (set) Token: 0x06008061 RID: 32865 RVA: 0x0025FD54 File Offset: 0x0025DF54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SubEntityInformation.Types.BindingPointCategoryEnum BindingPointCategory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SubEntityInformation.Types.BindingPointCategoryEnum)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x0025FD64 File Offset: 0x0025DF64
		// (set) Token: 0x06008063 RID: 32867 RVA: 0x0025FD74 File Offset: 0x0025DF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindingPointIndex
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

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x0025FD84 File Offset: 0x0025DF84
		// (set) Token: 0x06008065 RID: 32869 RVA: 0x0025FD94 File Offset: 0x0025DF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook SubEntityLook
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

		// Token: 0x06008066 RID: 32870 RVA: 0x0025FDA4 File Offset: 0x0025DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x0025FDB4 File Offset: 0x0025DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubEntityInformation other)
		{
			return true;
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x0025FDC4 File Offset: 0x0025DFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x0025FDD4 File Offset: 0x0025DFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0025FDE4 File Offset: 0x0025DFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x0025FDF4 File Offset: 0x0025DFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x0025FE04 File Offset: 0x0025E004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x0025FE14 File Offset: 0x0025E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubEntityInformation other)
		{
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x0025FE24 File Offset: 0x0025E024
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x0025FE34 File Offset: 0x0025E034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x0025FE44 File Offset: 0x0025E044
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubEntityInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					SubEntityInformation._parser = new MessageParser<SubEntityInformation>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x0025FF28 File Offset: 0x0025E128
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d5N5apJg9kmxYHbsr549()
		{
			return true;
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x0025FF30 File Offset: 0x0025E130
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubEntityInformation AoyNnHJg2etXYpcTbYdQ()
		{
			return null;
		}

		// Token: 0x04002E95 RID: 11925
		private static readonly MessageParser<SubEntityInformation> _parser;

		// Token: 0x04002E96 RID: 11926
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E97 RID: 11927
		public const int BindingPointCategoryFieldNumber = 1;

		// Token: 0x04002E98 RID: 11928
		private SubEntityInformation.Types.BindingPointCategoryEnum bindingPointCategory_;

		// Token: 0x04002E99 RID: 11929
		public const int BindingPointIndexFieldNumber = 2;

		// Token: 0x04002E9A RID: 11930
		private int bindingPointIndex_;

		// Token: 0x04002E9B RID: 11931
		public const int SubEntityLookFieldNumber = 3;

		// Token: 0x04002E9C RID: 11932
		private EntityLook subEntityLook_;

		// Token: 0x04002E9D RID: 11933
		internal static SubEntityInformation Abaf3UJgdGqVheeKWbdE;

		// Token: 0x02000A80 RID: 2688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06008073 RID: 32883 RVA: 0x002E05E0 File Offset: 0x002DE7E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A81 RID: 2689
			public enum BindingPointCategoryEnum
			{
				// Token: 0x04002E9F RID: 11935
				[OriginalName("HOOK_POINT_CATEGORY_UNUSED")]
				HookPointCategoryUnused,
				// Token: 0x04002EA0 RID: 11936
				[OriginalName("HOOK_POINT_CATEGORY_PET")]
				HookPointCategoryPet,
				// Token: 0x04002EA1 RID: 11937
				[OriginalName("HOOK_POINT_CATEGORY_MOUNT_DRIVER")]
				HookPointCategoryMountDriver,
				// Token: 0x04002EA2 RID: 11938
				[OriginalName("HOOK_POINT_CATEGORY_LIFTED_ENTITY")]
				HookPointCategoryLiftedEntity,
				// Token: 0x04002EA3 RID: 11939
				[OriginalName("HOOK_POINT_CATEGORY_BASE_BACKGROUND")]
				HookPointCategoryBaseBackground,
				// Token: 0x04002EA4 RID: 11940
				[OriginalName("HOOK_POINT_CATEGORY_BASE_FOREGROUND")]
				HookPointCategoryBaseForeground = 6,
				// Token: 0x04002EA5 RID: 11941
				[OriginalName("HOOK_POINT_CATEGORY_UNDERWATER_BUBBLES")]
				HookPointCategoryUnderwaterBubbles
			}
		}
	}
}
