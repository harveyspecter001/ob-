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
	// Token: 0x02000B9E RID: 2974
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockInformation : IMessage<PaddockInformation>, IMessage, IEquatable<PaddockInformation>, IDeepCloneable<PaddockInformation>, IBufferMessage
	{
		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x0026C908 File Offset: 0x0026AB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddockInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x0026C918 File Offset: 0x0026AB18
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

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x0026C928 File Offset: 0x0026AB28
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

		// Token: 0x06008F25 RID: 36645 RVA: 0x0026C938 File Offset: 0x0026AB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockInformation()
		{
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x0026C948 File Offset: 0x0026AB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockInformation(PaddockInformation other)
		{
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0026C958 File Offset: 0x0026AB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockInformation Clone()
		{
			return null;
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06008F28 RID: 36648 RVA: 0x0026C968 File Offset: 0x0026AB68
		// (set) Token: 0x06008F29 RID: 36649 RVA: 0x0026C978 File Offset: 0x0026AB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxOutdoorMount
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008F2A RID: 36650 RVA: 0x0026C988 File Offset: 0x0026AB88
		// (set) Token: 0x06008F2B RID: 36651 RVA: 0x0026C998 File Offset: 0x0026AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxItems
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

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008F2C RID: 36652 RVA: 0x0026C9A8 File Offset: 0x0026ABA8
		// (set) Token: 0x06008F2D RID: 36653 RVA: 0x0026C9B8 File Offset: 0x0026ABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PaddockInformation.Types.PaddockContent Content
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06008F2E RID: 36654 RVA: 0x0026C9C8 File Offset: 0x0026ABC8
		// (set) Token: 0x06008F2F RID: 36655 RVA: 0x0026C9D8 File Offset: 0x0026ABD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PaddockInformation.Types.PaddockInstances Instances
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

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06008F30 RID: 36656 RVA: 0x0026C9E8 File Offset: 0x0026ABE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PaddockInformation.InformationOneofCase InformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PaddockInformation.InformationOneofCase)null;
			}
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0026C9FC File Offset: 0x0026ABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearInformation()
		{
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0026CA0C File Offset: 0x0026AC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0026CA1C File Offset: 0x0026AC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockInformation other)
		{
			return true;
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x0026CA2C File Offset: 0x0026AC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0026CA3C File Offset: 0x0026AC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0026CA4C File Offset: 0x0026AC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0026CA5C File Offset: 0x0026AC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0026CA6C File Offset: 0x0026AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0026CA7C File Offset: 0x0026AC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockInformation other)
		{
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0026CA8C File Offset: 0x0026AC8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x0026CA9C File Offset: 0x0026AC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0026CAAC File Offset: 0x0026ACAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 0;
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PaddockInformation._parser = new MessageParser<PaddockInformation>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x0026CB90 File Offset: 0x0026AD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vr5UyBJ2foqVjAbj00tj()
		{
			return true;
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0026CB98 File Offset: 0x0026AD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockInformation WHuJOcJ2n3t5LHcwqJnn()
		{
			return null;
		}

		// Token: 0x0400354F RID: 13647
		private static readonly MessageParser<PaddockInformation> _parser;

		// Token: 0x04003550 RID: 13648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003551 RID: 13649
		public const int MaxOutdoorMountFieldNumber = 1;

		// Token: 0x04003552 RID: 13650
		private int maxOutdoorMount_;

		// Token: 0x04003553 RID: 13651
		public const int MaxItemsFieldNumber = 2;

		// Token: 0x04003554 RID: 13652
		private int maxItems_;

		// Token: 0x04003555 RID: 13653
		public const int ContentFieldNumber = 3;

		// Token: 0x04003556 RID: 13654
		public const int InstancesFieldNumber = 4;

		// Token: 0x04003557 RID: 13655
		private object information_;

		// Token: 0x04003558 RID: 13656
		private PaddockInformation.InformationOneofCase informationCase_;

		// Token: 0x04003559 RID: 13657
		internal static PaddockInformation WJCje8J9ze7KkEBIS7k1;

		// Token: 0x02000B9F RID: 2975
		public enum InformationOneofCase
		{
			// Token: 0x0400355B RID: 13659
			None,
			// Token: 0x0400355C RID: 13660
			Content = 3,
			// Token: 0x0400355D RID: 13661
			Instances
		}

		// Token: 0x02000BA0 RID: 2976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06008F3F RID: 36671 RVA: 0x002E5204 File Offset: 0x002E3404
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000BA1 RID: 2977
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PaddockContent : IMessage<PaddockInformation.Types.PaddockContent>, IMessage, IEquatable<PaddockInformation.Types.PaddockContent>, IDeepCloneable<PaddockInformation.Types.PaddockContent>, IBufferMessage
			{
				// Token: 0x17001ACC RID: 6860
				// (get) Token: 0x06008F40 RID: 36672 RVA: 0x0030CC0C File Offset: 0x0030AE0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PaddockInformation.Types.PaddockContent> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001ACD RID: 6861
				// (get) Token: 0x06008F41 RID: 36673 RVA: 0x0030CC1C File Offset: 0x0030AE1C
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

				// Token: 0x17001ACE RID: 6862
				// (get) Token: 0x06008F42 RID: 36674 RVA: 0x0030CC2C File Offset: 0x0030AE2C
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

				// Token: 0x06008F43 RID: 36675 RVA: 0x0030CC3C File Offset: 0x0030AE3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockContent()
				{
				}

				// Token: 0x06008F44 RID: 36676 RVA: 0x0030CC4C File Offset: 0x0030AE4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockContent(PaddockInformation.Types.PaddockContent other)
				{
				}

				// Token: 0x06008F45 RID: 36677 RVA: 0x0030CC5C File Offset: 0x0030AE5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockInformation.Types.PaddockContent Clone()
				{
					return null;
				}

				// Token: 0x17001ACF RID: 6863
				// (get) Token: 0x06008F46 RID: 36678 RVA: 0x0030CC6C File Offset: 0x0030AE6C
				// (set) Token: 0x06008F47 RID: 36679 RVA: 0x0030CC7C File Offset: 0x0030AE7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long PaddockId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17001AD0 RID: 6864
				// (get) Token: 0x06008F48 RID: 36680 RVA: 0x0030CC8C File Offset: 0x0030AE8C
				// (set) Token: 0x06008F49 RID: 36681 RVA: 0x0030CC9C File Offset: 0x0030AE9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public MapExtendedCoordinates Coordinates
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

				// Token: 0x17001AD1 RID: 6865
				// (get) Token: 0x06008F4A RID: 36682 RVA: 0x0030CCAC File Offset: 0x0030AEAC
				// (set) Token: 0x06008F4B RID: 36683 RVA: 0x0030CCBC File Offset: 0x0030AEBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Abandoned
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

				// Token: 0x17001AD2 RID: 6866
				// (get) Token: 0x06008F4C RID: 36684 RVA: 0x0030CCCC File Offset: 0x0030AECC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<PaddockInformation.Types.PaddockContent.Types.MountForPaddock> MountsInformation
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06008F4D RID: 36685 RVA: 0x0030CCDC File Offset: 0x0030AEDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008F4E RID: 36686 RVA: 0x0030CCEC File Offset: 0x0030AEEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PaddockInformation.Types.PaddockContent other)
				{
					return true;
				}

				// Token: 0x06008F4F RID: 36687 RVA: 0x0030CCFC File Offset: 0x0030AEFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008F50 RID: 36688 RVA: 0x0030CD0C File Offset: 0x0030AF0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008F51 RID: 36689 RVA: 0x0030CD1C File Offset: 0x0030AF1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008F52 RID: 36690 RVA: 0x0030CD2C File Offset: 0x0030AF2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008F53 RID: 36691 RVA: 0x0030CD3C File Offset: 0x0030AF3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008F54 RID: 36692 RVA: 0x0030CD4C File Offset: 0x0030AF4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PaddockInformation.Types.PaddockContent other)
				{
				}

				// Token: 0x06008F55 RID: 36693 RVA: 0x0030CD5C File Offset: 0x0030AF5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008F56 RID: 36694 RVA: 0x0030CD6C File Offset: 0x0030AF6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008F57 RID: 36695 RVA: 0x0030CD7C File Offset: 0x0030AF7C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PaddockContent()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							PaddockInformation.Types.PaddockContent._repeated_mountsInformation_codec = FieldCodec.ForMessage<PaddockInformation.Types.PaddockContent.Types.MountForPaddock>(34U, OpmdoCBlYJiF6Mubn1g8.XVInXhlssT(OpmdoCBlYJiF6Mubn1g8.CU6Blb0vxsA));
							num2 = 5;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							return;
						}
						PaddockInformation.Types.PaddockContent._parser = new MessageParser<PaddockInformation.Types.PaddockContent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06008F58 RID: 36696 RVA: 0x0030CEAC File Offset: 0x0030B0AC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool R0f0HqGZsdv8bKXZSuk1()
				{
					return true;
				}

				// Token: 0x06008F59 RID: 36697 RVA: 0x0030CEB4 File Offset: 0x0030B0B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PaddockInformation.Types.PaddockContent qcobVPGZdOpyMxllaYeV()
				{
					return null;
				}

				// Token: 0x0400355E RID: 13662
				private static readonly MessageParser<PaddockInformation.Types.PaddockContent> _parser;

				// Token: 0x0400355F RID: 13663
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003560 RID: 13664
				public const int PaddockIdFieldNumber = 1;

				// Token: 0x04003561 RID: 13665
				private long paddockId_;

				// Token: 0x04003562 RID: 13666
				public const int CoordinatesFieldNumber = 2;

				// Token: 0x04003563 RID: 13667
				private MapExtendedCoordinates coordinates_;

				// Token: 0x04003564 RID: 13668
				public const int AbandonedFieldNumber = 3;

				// Token: 0x04003565 RID: 13669
				private bool abandoned_;

				// Token: 0x04003566 RID: 13670
				public const int MountsInformationFieldNumber = 4;

				// Token: 0x04003567 RID: 13671
				private static readonly FieldCodec<PaddockInformation.Types.PaddockContent.Types.MountForPaddock> _repeated_mountsInformation_codec;

				// Token: 0x04003568 RID: 13672
				private readonly RepeatedField<PaddockInformation.Types.PaddockContent.Types.MountForPaddock> mountsInformation_;

				// Token: 0x04003569 RID: 13673
				private static PaddockInformation.Types.PaddockContent t8ssoOGZgaE9wVXHdcVd;

				// Token: 0x02000BA2 RID: 2978
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x06008F5A RID: 36698 RVA: 0x00319914 File Offset: 0x00317B14
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000BA3 RID: 2979
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class MountForPaddock : IMessage<PaddockInformation.Types.PaddockContent.Types.MountForPaddock>, IMessage, IEquatable<PaddockInformation.Types.PaddockContent.Types.MountForPaddock>, IDeepCloneable<PaddockInformation.Types.PaddockContent.Types.MountForPaddock>, IBufferMessage
					{
						// Token: 0x17001AD3 RID: 6867
						// (get) Token: 0x06008F5B RID: 36699 RVA: 0x0031E754 File Offset: 0x0031C954
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<PaddockInformation.Types.PaddockContent.Types.MountForPaddock> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001AD4 RID: 6868
						// (get) Token: 0x06008F5C RID: 36700 RVA: 0x0031E764 File Offset: 0x0031C964
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

						// Token: 0x17001AD5 RID: 6869
						// (get) Token: 0x06008F5D RID: 36701 RVA: 0x0031E774 File Offset: 0x0031C974
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

						// Token: 0x06008F5E RID: 36702 RVA: 0x0031E784 File Offset: 0x0031C984
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public MountForPaddock()
						{
						}

						// Token: 0x06008F5F RID: 36703 RVA: 0x0031E794 File Offset: 0x0031C994
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public MountForPaddock(PaddockInformation.Types.PaddockContent.Types.MountForPaddock other)
						{
						}

						// Token: 0x06008F60 RID: 36704 RVA: 0x0031E7A4 File Offset: 0x0031C9A4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PaddockInformation.Types.PaddockContent.Types.MountForPaddock Clone()
						{
							return null;
						}

						// Token: 0x17001AD6 RID: 6870
						// (get) Token: 0x06008F61 RID: 36705 RVA: 0x0031E7B4 File Offset: 0x0031C9B4
						// (set) Token: 0x06008F62 RID: 36706 RVA: 0x0031E7C4 File Offset: 0x0031C9C4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int ModelId
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

						// Token: 0x17001AD7 RID: 6871
						// (get) Token: 0x06008F63 RID: 36707 RVA: 0x0031E7D4 File Offset: 0x0031C9D4
						// (set) Token: 0x06008F64 RID: 36708 RVA: 0x0031E7E4 File Offset: 0x0031C9E4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public string Name
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

						// Token: 0x17001AD8 RID: 6872
						// (get) Token: 0x06008F65 RID: 36709 RVA: 0x0031E7F4 File Offset: 0x0031C9F4
						// (set) Token: 0x06008F66 RID: 36710 RVA: 0x0031E804 File Offset: 0x0031CA04
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public string OwnerName
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

						// Token: 0x06008F67 RID: 36711 RVA: 0x0031E814 File Offset: 0x0031CA14
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06008F68 RID: 36712 RVA: 0x0031E824 File Offset: 0x0031CA24
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(PaddockInformation.Types.PaddockContent.Types.MountForPaddock other)
						{
							return true;
						}

						// Token: 0x06008F69 RID: 36713 RVA: 0x0031E834 File Offset: 0x0031CA34
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06008F6A RID: 36714 RVA: 0x0031E844 File Offset: 0x0031CA44
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06008F6B RID: 36715 RVA: 0x0031E854 File Offset: 0x0031CA54
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06008F6C RID: 36716 RVA: 0x0031E864 File Offset: 0x0031CA64
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06008F6D RID: 36717 RVA: 0x0031E874 File Offset: 0x0031CA74
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06008F6E RID: 36718 RVA: 0x0031E884 File Offset: 0x0031CA84
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(PaddockInformation.Types.PaddockContent.Types.MountForPaddock other)
						{
						}

						// Token: 0x06008F6F RID: 36719 RVA: 0x0031E894 File Offset: 0x0031CA94
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06008F70 RID: 36720 RVA: 0x0031E8A4 File Offset: 0x0031CAA4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06008F71 RID: 36721 RVA: 0x0031E8B4 File Offset: 0x0031CAB4
						[MethodImpl(MethodImplOptions.NoInlining)]
						static MountForPaddock()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 3;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									return;
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								PaddockInformation.Types.PaddockContent.Types.MountForPaddock._parser = new MessageParser<PaddockInformation.Types.PaddockContent.Types.MountForPaddock>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
								{
									num2 = 0;
								}
							}
						}

						// Token: 0x06008F72 RID: 36722 RVA: 0x0031E980 File Offset: 0x0031CB80
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool hbb8elgGOOlUnsVB4WNC()
						{
							return true;
						}

						// Token: 0x06008F73 RID: 36723 RVA: 0x0031E988 File Offset: 0x0031CB88
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static PaddockInformation.Types.PaddockContent.Types.MountForPaddock cIDZNXgGJrRKZ7UbwDqA()
						{
							return null;
						}

						// Token: 0x0400356A RID: 13674
						private static readonly MessageParser<PaddockInformation.Types.PaddockContent.Types.MountForPaddock> _parser;

						// Token: 0x0400356B RID: 13675
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400356C RID: 13676
						public const int ModelIdFieldNumber = 1;

						// Token: 0x0400356D RID: 13677
						private int modelId_;

						// Token: 0x0400356E RID: 13678
						public const int NameFieldNumber = 2;

						// Token: 0x0400356F RID: 13679
						private string name_;

						// Token: 0x04003570 RID: 13680
						public const int OwnerNameFieldNumber = 3;

						// Token: 0x04003571 RID: 13681
						private string ownerName_;

						// Token: 0x04003572 RID: 13682
						internal static PaddockInformation.Types.PaddockContent.Types.MountForPaddock l2ZbnWgGRrXwVISw7BjV;
					}
				}
			}

			// Token: 0x02000BA6 RID: 2982
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PaddockInstances : IMessage<PaddockInformation.Types.PaddockInstances>, IMessage, IEquatable<PaddockInformation.Types.PaddockInstances>, IDeepCloneable<PaddockInformation.Types.PaddockInstances>, IBufferMessage
			{
				// Token: 0x17001AD9 RID: 6873
				// (get) Token: 0x06008F7E RID: 36734 RVA: 0x0030CEBC File Offset: 0x0030B0BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PaddockInformation.Types.PaddockInstances> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001ADA RID: 6874
				// (get) Token: 0x06008F7F RID: 36735 RVA: 0x0030CECC File Offset: 0x0030B0CC
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

				// Token: 0x17001ADB RID: 6875
				// (get) Token: 0x06008F80 RID: 36736 RVA: 0x0030CEDC File Offset: 0x0030B0DC
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

				// Token: 0x06008F81 RID: 36737 RVA: 0x0030CEEC File Offset: 0x0030B0EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockInstances()
				{
				}

				// Token: 0x06008F82 RID: 36738 RVA: 0x0030CEFC File Offset: 0x0030B0FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockInstances(PaddockInformation.Types.PaddockInstances other)
				{
				}

				// Token: 0x06008F83 RID: 36739 RVA: 0x0030CF0C File Offset: 0x0030B10C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockInformation.Types.PaddockInstances Clone()
				{
					return null;
				}

				// Token: 0x17001ADC RID: 6876
				// (get) Token: 0x06008F84 RID: 36740 RVA: 0x0030CF1C File Offset: 0x0030B11C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell> PaddocksToSell
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06008F85 RID: 36741 RVA: 0x0030CF2C File Offset: 0x0030B12C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008F86 RID: 36742 RVA: 0x0030CF3C File Offset: 0x0030B13C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PaddockInformation.Types.PaddockInstances other)
				{
					return true;
				}

				// Token: 0x06008F87 RID: 36743 RVA: 0x0030CF4C File Offset: 0x0030B14C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008F88 RID: 36744 RVA: 0x0030CF5C File Offset: 0x0030B15C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008F89 RID: 36745 RVA: 0x0030CF6C File Offset: 0x0030B16C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008F8A RID: 36746 RVA: 0x0030CF7C File Offset: 0x0030B17C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008F8B RID: 36747 RVA: 0x0030CF8C File Offset: 0x0030B18C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008F8C RID: 36748 RVA: 0x0030CF9C File Offset: 0x0030B19C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PaddockInformation.Types.PaddockInstances other)
				{
				}

				// Token: 0x06008F8D RID: 36749 RVA: 0x0030CFAC File Offset: 0x0030B1AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008F8E RID: 36750 RVA: 0x0030CFBC File Offset: 0x0030B1BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008F8F RID: 36751 RVA: 0x0030CFCC File Offset: 0x0030B1CC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PaddockInstances()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								PaddockInformation.Types.PaddockInstances._parser = new MessageParser<PaddockInformation.Types.PaddockInstances>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								goto IL_3A;
							case 5:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							PaddockInformation.Types.PaddockInstances._repeated_paddocksToSell_codec = FieldCodec.ForMessage<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell>(10U, f2WXpPBlSjMXV3xLaeRS.XVInXhlssT(f2WXpPBlSjMXV3xLaeRS.Jh8BlMR9nHf));
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
							{
								num2 = 2;
							}
						}
						IL_3A:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 3;
					}
				}

				// Token: 0x06008F90 RID: 36752 RVA: 0x0030D0EC File Offset: 0x0030B2EC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TTR8LfGZ2w9jfvV05s55()
				{
					return true;
				}

				// Token: 0x06008F91 RID: 36753 RVA: 0x0030D0F4 File Offset: 0x0030B2F4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PaddockInformation.Types.PaddockInstances Kw5a5EGZEumEyXKFd50J()
				{
					return null;
				}

				// Token: 0x04003577 RID: 13687
				private static readonly MessageParser<PaddockInformation.Types.PaddockInstances> _parser;

				// Token: 0x04003578 RID: 13688
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003579 RID: 13689
				public const int PaddocksToSellFieldNumber = 1;

				// Token: 0x0400357A RID: 13690
				private static readonly FieldCodec<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell> _repeated_paddocksToSell_codec;

				// Token: 0x0400357B RID: 13691
				private readonly RepeatedField<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell> paddocksToSell_;

				// Token: 0x0400357C RID: 13692
				private static PaddockInformation.Types.PaddockInstances iMcUwRGZ94LBohPRBThd;

				// Token: 0x02000BA7 RID: 2983
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x06008F92 RID: 36754 RVA: 0x00319A24 File Offset: 0x00317C24
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000BA8 RID: 2984
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class PaddockToSell : IMessage<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell>, IMessage, IEquatable<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell>, IDeepCloneable<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell>, IBufferMessage
					{
						// Token: 0x17001ADD RID: 6877
						// (get) Token: 0x06008F93 RID: 36755 RVA: 0x0031E990 File Offset: 0x0031CB90
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001ADE RID: 6878
						// (get) Token: 0x06008F94 RID: 36756 RVA: 0x0031E9A0 File Offset: 0x0031CBA0
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

						// Token: 0x17001ADF RID: 6879
						// (get) Token: 0x06008F95 RID: 36757 RVA: 0x0031E9B0 File Offset: 0x0031CBB0
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

						// Token: 0x06008F96 RID: 36758 RVA: 0x0031E9C0 File Offset: 0x0031CBC0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PaddockToSell()
						{
						}

						// Token: 0x06008F97 RID: 36759 RVA: 0x0031E9D0 File Offset: 0x0031CBD0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PaddockToSell(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell other)
						{
						}

						// Token: 0x06008F98 RID: 36760 RVA: 0x0031E9E0 File Offset: 0x0031CBE0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public PaddockInformation.Types.PaddockInstances.Types.PaddockToSell Clone()
						{
							return null;
						}

						// Token: 0x17001AE0 RID: 6880
						// (get) Token: 0x06008F99 RID: 36761 RVA: 0x0031E9F0 File Offset: 0x0031CBF0
						// (set) Token: 0x06008F9A RID: 36762 RVA: 0x0031EA00 File Offset: 0x0031CC00
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public long Price
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return 0L;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17001AE1 RID: 6881
						// (get) Token: 0x06008F9B RID: 36763 RVA: 0x0031EA10 File Offset: 0x0031CC10
						// (set) Token: 0x06008F9C RID: 36764 RVA: 0x0031EA20 File Offset: 0x0031CC20
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool Locked
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

						// Token: 0x17001AE2 RID: 6882
						// (get) Token: 0x06008F9D RID: 36765 RVA: 0x0031EA30 File Offset: 0x0031CC30
						// (set) Token: 0x06008F9E RID: 36766 RVA: 0x0031EA40 File Offset: 0x0031CC40
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation GuildInformation
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

						// Token: 0x06008F9F RID: 36767 RVA: 0x0031EA50 File Offset: 0x0031CC50
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06008FA0 RID: 36768 RVA: 0x0031EA60 File Offset: 0x0031CC60
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell other)
						{
							return true;
						}

						// Token: 0x06008FA1 RID: 36769 RVA: 0x0031EA70 File Offset: 0x0031CC70
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06008FA2 RID: 36770 RVA: 0x0031EA80 File Offset: 0x0031CC80
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06008FA3 RID: 36771 RVA: 0x0031EA90 File Offset: 0x0031CC90
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06008FA4 RID: 36772 RVA: 0x0031EAA0 File Offset: 0x0031CCA0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06008FA5 RID: 36773 RVA: 0x0031EAB0 File Offset: 0x0031CCB0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06008FA6 RID: 36774 RVA: 0x0031EAC0 File Offset: 0x0031CCC0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell other)
						{
						}

						// Token: 0x06008FA7 RID: 36775 RVA: 0x0031EAD0 File Offset: 0x0031CCD0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06008FA8 RID: 36776 RVA: 0x0031EAE0 File Offset: 0x0031CCE0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06008FA9 RID: 36777 RVA: 0x0031EAF0 File Offset: 0x0031CCF0
						[MethodImpl(MethodImplOptions.NoInlining)]
						static PaddockToSell()
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
										goto IL_88;
									case 2:
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
										{
											num2 = 1;
											continue;
										}
										continue;
									case 3:
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 4:
										return;
									}
									PaddockInformation.Types.PaddockInstances.Types.PaddockToSell._parser = new MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell>(() => null);
									num2 = 4;
								}
								IL_88:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num = 3;
							}
						}

						// Token: 0x06008FAA RID: 36778 RVA: 0x0031EBC0 File Offset: 0x0031CDC0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool MoHlsKgGgnCtT9kNlg6X()
						{
							return true;
						}

						// Token: 0x06008FAB RID: 36779 RVA: 0x0031EBC8 File Offset: 0x0031CDC8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static PaddockInformation.Types.PaddockInstances.Types.PaddockToSell lfwwTtgGsyflr7hPoEcx()
						{
							return null;
						}

						// Token: 0x0400357D RID: 13693
						private static readonly MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell> _parser;

						// Token: 0x0400357E RID: 13694
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400357F RID: 13695
						public const int PriceFieldNumber = 1;

						// Token: 0x04003580 RID: 13696
						private long price_;

						// Token: 0x04003581 RID: 13697
						public const int LockedFieldNumber = 2;

						// Token: 0x04003582 RID: 13698
						private bool locked_;

						// Token: 0x04003583 RID: 13699
						public const int GuildInformationFieldNumber = 3;

						// Token: 0x04003584 RID: 13700
						private PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation guildInformation_;

						// Token: 0x04003585 RID: 13701
						private static PaddockInformation.Types.PaddockInstances.Types.PaddockToSell pjvFSAgGGs8KKiB6gxin;

						// Token: 0x02000BA9 RID: 2985
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static class Types
						{
							// Token: 0x06008FAC RID: 36780 RVA: 0x00322134 File Offset: 0x00320334
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x02000BAA RID: 2986
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class PaddockGuildInformation : IMessage<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation>, IMessage, IEquatable<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation>, IDeepCloneable<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation>, IBufferMessage
							{
								// Token: 0x17001AE3 RID: 6883
								// (get) Token: 0x06008FAD RID: 36781 RVA: 0x00324D68 File Offset: 0x00322F68
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17001AE4 RID: 6884
								// (get) Token: 0x06008FAE RID: 36782 RVA: 0x00324D78 File Offset: 0x00322F78
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

								// Token: 0x17001AE5 RID: 6885
								// (get) Token: 0x06008FAF RID: 36783 RVA: 0x00324D88 File Offset: 0x00322F88
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

								// Token: 0x06008FB0 RID: 36784 RVA: 0x00324D98 File Offset: 0x00322F98
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public PaddockGuildInformation()
								{
								}

								// Token: 0x06008FB1 RID: 36785 RVA: 0x00324DA8 File Offset: 0x00322FA8
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public PaddockGuildInformation(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation other)
								{
								}

								// Token: 0x06008FB2 RID: 36786 RVA: 0x00324DB8 File Offset: 0x00322FB8
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation Clone()
								{
									return null;
								}

								// Token: 0x17001AE6 RID: 6886
								// (get) Token: 0x06008FB3 RID: 36787 RVA: 0x00324DC8 File Offset: 0x00322FC8
								// (set) Token: 0x06008FB4 RID: 36788 RVA: 0x00324DD8 File Offset: 0x00322FD8
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public bool Deserted
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

								// Token: 0x17001AE7 RID: 6887
								// (get) Token: 0x06008FB5 RID: 36789 RVA: 0x00324DE8 File Offset: 0x00322FE8
								// (set) Token: 0x06008FB6 RID: 36790 RVA: 0x00324DF8 File Offset: 0x00322FF8
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public GuildInformation GuildInformation
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

								// Token: 0x06008FB7 RID: 36791 RVA: 0x00324E08 File Offset: 0x00323008
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06008FB8 RID: 36792 RVA: 0x00324E18 File Offset: 0x00323018
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation other)
								{
									return true;
								}

								// Token: 0x06008FB9 RID: 36793 RVA: 0x00324E28 File Offset: 0x00323028
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06008FBA RID: 36794 RVA: 0x00324E38 File Offset: 0x00323038
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06008FBB RID: 36795 RVA: 0x00324E48 File Offset: 0x00323048
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06008FBC RID: 36796 RVA: 0x00324E58 File Offset: 0x00323058
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06008FBD RID: 36797 RVA: 0x00324E68 File Offset: 0x00323068
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06008FBE RID: 36798 RVA: 0x00324E78 File Offset: 0x00323078
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation other)
								{
								}

								// Token: 0x06008FBF RID: 36799 RVA: 0x00324E88 File Offset: 0x00323088
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06008FC0 RID: 36800 RVA: 0x00324E98 File Offset: 0x00323098
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06008FC1 RID: 36801 RVA: 0x00324EA8 File Offset: 0x003230A8
								[MethodImpl(MethodImplOptions.NoInlining)]
								static PaddockGuildInformation()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
											{
												num2 = 1;
												continue;
											}
											continue;
										case 3:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
											{
												num2 = 2;
												continue;
											}
											continue;
										case 4:
											return;
										}
										PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation._parser = new MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation>(() => null);
										num2 = 4;
									}
								}

								// Token: 0x06008FC2 RID: 36802 RVA: 0x00324F8C File Offset: 0x0032318C
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool ldslkcg9AUx2VYB28cvD()
								{
									return true;
								}

								// Token: 0x06008FC3 RID: 36803 RVA: 0x00324F94 File Offset: 0x00323194
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation DIcYuZg9BRKMXqZOXqJu()
								{
									return null;
								}

								// Token: 0x04003586 RID: 13702
								private static readonly MessageParser<PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation> _parser;

								// Token: 0x04003587 RID: 13703
								private UnknownFieldSet _unknownFields;

								// Token: 0x04003588 RID: 13704
								public const int DesertedFieldNumber = 1;

								// Token: 0x04003589 RID: 13705
								private bool deserted_;

								// Token: 0x0400358A RID: 13706
								public const int GuildInformationFieldNumber = 2;

								// Token: 0x0400358B RID: 13707
								private GuildInformation guildInformation_;

								// Token: 0x0400358C RID: 13708
								internal static PaddockInformation.Types.PaddockInstances.Types.PaddockToSell.Types.PaddockGuildInformation HFpZOsg9m2iRkLF4ntRe;
							}
						}
					}
				}
			}
		}
	}
}
