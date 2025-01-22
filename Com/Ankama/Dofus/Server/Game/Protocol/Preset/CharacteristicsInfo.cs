using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001EA RID: 490
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacteristicsInfo : IMessage<CharacteristicsInfo>, IMessage, IEquatable<CharacteristicsInfo>, IDeepCloneable<CharacteristicsInfo>, IBufferMessage
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x001AD0FC File Offset: 0x001AB2FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacteristicsInfo> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x001AD10C File Offset: 0x001AB30C
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x001AD11C File Offset: 0x001AB31C
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

		// Token: 0x060016E7 RID: 5863 RVA: 0x001AD12C File Offset: 0x001AB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacteristicsInfo()
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x001AD13C File Offset: 0x001AB33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacteristicsInfo(CharacteristicsInfo other)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x001AD14C File Offset: 0x001AB34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacteristicsInfo Clone()
		{
			return null;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x001AD15C File Offset: 0x001AB35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry> CharacteristicDetailsById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x001AD16C File Offset: 0x001AB36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x001AD17C File Offset: 0x001AB37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacteristicsInfo other)
		{
			return true;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x001AD18C File Offset: 0x001AB38C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x001AD19C File Offset: 0x001AB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x001AD1AC File Offset: 0x001AB3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x001AD1BC File Offset: 0x001AB3BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x001AD1CC File Offset: 0x001AB3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x001AD1DC File Offset: 0x001AB3DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacteristicsInfo other)
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x001AD1EC File Offset: 0x001AB3EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x001AD1FC File Offset: 0x001AB3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x001AD20C File Offset: 0x001AB40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacteristicsInfo()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					CharacteristicsInfo._parser = new MessageParser<CharacteristicsInfo>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				CharacteristicsInfo._repeated_characteristicDetailsById_codec = FieldCodec.ForMessage<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry>(10U, uOY6Ho8WDG7T83inXDt.XVInXhlssT(uOY6Ho8WDG7T83inXDt.odU8hskYEL));
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x001AD314 File Offset: 0x001AB514
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ChCCBaO1HJxfV72TdFtB()
		{
			return true;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x001AD31C File Offset: 0x001AB51C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacteristicsInfo eWOogWO1YmCidubKega8()
		{
			return null;
		}

		// Token: 0x04000828 RID: 2088
		private static readonly MessageParser<CharacteristicsInfo> _parser;

		// Token: 0x04000829 RID: 2089
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400082A RID: 2090
		public const int CharacteristicDetailsByIdFieldNumber = 1;

		// Token: 0x0400082B RID: 2091
		private static readonly FieldCodec<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry> _repeated_characteristicDetailsById_codec;

		// Token: 0x0400082C RID: 2092
		private readonly RepeatedField<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry> characteristicDetailsById_;

		// Token: 0x0400082D RID: 2093
		internal static CharacteristicsInfo NdNvD5O1pTvfjFQ4ikIx;

		// Token: 0x020001EB RID: 491
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060016F8 RID: 5880 RVA: 0x002B05F0 File Offset: 0x002AE7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001EC RID: 492
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CharacteristicDetailsByIdEntry : IMessage<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry>, IMessage, IEquatable<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry>, IDeepCloneable<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry>, IBufferMessage
			{
				// Token: 0x17000415 RID: 1045
				// (get) Token: 0x060016F9 RID: 5881 RVA: 0x002F8618 File Offset: 0x002F6818
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000416 RID: 1046
				// (get) Token: 0x060016FA RID: 5882 RVA: 0x002F8628 File Offset: 0x002F6828
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

				// Token: 0x17000417 RID: 1047
				// (get) Token: 0x060016FB RID: 5883 RVA: 0x002F8638 File Offset: 0x002F6838
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

				// Token: 0x060016FC RID: 5884 RVA: 0x002F8648 File Offset: 0x002F6848
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicDetailsByIdEntry()
				{
				}

				// Token: 0x060016FD RID: 5885 RVA: 0x002F8658 File Offset: 0x002F6858
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicDetailsByIdEntry(CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry other)
				{
				}

				// Token: 0x060016FE RID: 5886 RVA: 0x002F8668 File Offset: 0x002F6868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x17000418 RID: 1048
				// (get) Token: 0x060016FF RID: 5887 RVA: 0x002F8678 File Offset: 0x002F6878
				// (set) Token: 0x06001700 RID: 5888 RVA: 0x002F8688 File Offset: 0x002F6888
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Key
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

				// Token: 0x17000419 RID: 1049
				// (get) Token: 0x06001701 RID: 5889 RVA: 0x002F8698 File Offset: 0x002F6898
				// (set) Token: 0x06001702 RID: 5890 RVA: 0x002F86A8 File Offset: 0x002F68A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public CharacteristicsInfo.Types.CharacteristicsDetails Value
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

				// Token: 0x06001703 RID: 5891 RVA: 0x002F86B8 File Offset: 0x002F68B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001704 RID: 5892 RVA: 0x002F86C8 File Offset: 0x002F68C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry other)
				{
					return true;
				}

				// Token: 0x06001705 RID: 5893 RVA: 0x002F86D8 File Offset: 0x002F68D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001706 RID: 5894 RVA: 0x002F86E8 File Offset: 0x002F68E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001707 RID: 5895 RVA: 0x002F86F8 File Offset: 0x002F68F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001708 RID: 5896 RVA: 0x002F8708 File Offset: 0x002F6908
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001709 RID: 5897 RVA: 0x002F8718 File Offset: 0x002F6918
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600170A RID: 5898 RVA: 0x002F8728 File Offset: 0x002F6928
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry other)
				{
				}

				// Token: 0x0600170B RID: 5899 RVA: 0x002F8738 File Offset: 0x002F6938
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600170C RID: 5900 RVA: 0x002F8748 File Offset: 0x002F6948
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600170D RID: 5901 RVA: 0x002F8758 File Offset: 0x002F6958
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CharacteristicDetailsByIdEntry()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry._parser = new MessageParser<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry>(() => null);
							num2 = 4;
							break;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x0600170E RID: 5902 RVA: 0x002F8824 File Offset: 0x002F6A24
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool koJGxtGprE0IuEUY12Cn()
				{
					return true;
				}

				// Token: 0x0600170F RID: 5903 RVA: 0x002F882C File Offset: 0x002F6A2C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry cyDE28GpVcNwTbelPrH3()
				{
					return null;
				}

				// Token: 0x0400082E RID: 2094
				private static readonly MessageParser<CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry> _parser;

				// Token: 0x0400082F RID: 2095
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000830 RID: 2096
				public const int KeyFieldNumber = 1;

				// Token: 0x04000831 RID: 2097
				private int key_;

				// Token: 0x04000832 RID: 2098
				public const int ValueFieldNumber = 2;

				// Token: 0x04000833 RID: 2099
				private CharacteristicsInfo.Types.CharacteristicsDetails value_;

				// Token: 0x04000834 RID: 2100
				private static CharacteristicsInfo.Types.CharacteristicDetailsByIdEntry tKFl8ZGphePLOp6LJsBJ;
			}

			// Token: 0x020001EE RID: 494
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CharacteristicsDetails : IMessage<CharacteristicsInfo.Types.CharacteristicsDetails>, IMessage, IEquatable<CharacteristicsInfo.Types.CharacteristicsDetails>, IDeepCloneable<CharacteristicsInfo.Types.CharacteristicsDetails>, IBufferMessage
			{
				// Token: 0x1700041A RID: 1050
				// (get) Token: 0x06001715 RID: 5909 RVA: 0x002F8834 File Offset: 0x002F6A34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacteristicsInfo.Types.CharacteristicsDetails> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700041B RID: 1051
				// (get) Token: 0x06001716 RID: 5910 RVA: 0x002F8844 File Offset: 0x002F6A44
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

				// Token: 0x1700041C RID: 1052
				// (get) Token: 0x06001717 RID: 5911 RVA: 0x002F8854 File Offset: 0x002F6A54
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

				// Token: 0x06001718 RID: 5912 RVA: 0x002F8864 File Offset: 0x002F6A64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicsDetails()
				{
				}

				// Token: 0x06001719 RID: 5913 RVA: 0x002F8874 File Offset: 0x002F6A74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicsDetails(CharacteristicsInfo.Types.CharacteristicsDetails other)
				{
				}

				// Token: 0x0600171A RID: 5914 RVA: 0x002F8884 File Offset: 0x002F6A84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacteristicsInfo.Types.CharacteristicsDetails Clone()
				{
					return null;
				}

				// Token: 0x1700041D RID: 1053
				// (get) Token: 0x0600171B RID: 5915 RVA: 0x002F8894 File Offset: 0x002F6A94
				// (set) Token: 0x0600171C RID: 5916 RVA: 0x002F88A4 File Offset: 0x002F6AA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FromBase
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

				// Token: 0x1700041E RID: 1054
				// (get) Token: 0x0600171D RID: 5917 RVA: 0x002F88B4 File Offset: 0x002F6AB4
				// (set) Token: 0x0600171E RID: 5918 RVA: 0x002F88C4 File Offset: 0x002F6AC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FromAllocated
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

				// Token: 0x1700041F RID: 1055
				// (get) Token: 0x0600171F RID: 5919 RVA: 0x002F88D4 File Offset: 0x002F6AD4
				// (set) Token: 0x06001720 RID: 5920 RVA: 0x002F88E4 File Offset: 0x002F6AE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FromEquipment
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

				// Token: 0x17000420 RID: 1056
				// (get) Token: 0x06001721 RID: 5921 RVA: 0x002F88F4 File Offset: 0x002F6AF4
				// (set) Token: 0x06001722 RID: 5922 RVA: 0x002F8904 File Offset: 0x002F6B04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FromBonus
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

				// Token: 0x17000421 RID: 1057
				// (get) Token: 0x06001723 RID: 5923 RVA: 0x002F8914 File Offset: 0x002F6B14
				// (set) Token: 0x06001724 RID: 5924 RVA: 0x002F8924 File Offset: 0x002F6B24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FromInitialBonus
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

				// Token: 0x17000422 RID: 1058
				// (get) Token: 0x06001725 RID: 5925 RVA: 0x002F8934 File Offset: 0x002F6B34
				// (set) Token: 0x06001726 RID: 5926 RVA: 0x002F8944 File Offset: 0x002F6B44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Limit
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

				// Token: 0x17000423 RID: 1059
				// (get) Token: 0x06001727 RID: 5927 RVA: 0x002F8954 File Offset: 0x002F6B54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasLimit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06001728 RID: 5928 RVA: 0x002F8964 File Offset: 0x002F6B64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearLimit()
				{
				}

				// Token: 0x06001729 RID: 5929 RVA: 0x002F8974 File Offset: 0x002F6B74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600172A RID: 5930 RVA: 0x002F8984 File Offset: 0x002F6B84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacteristicsInfo.Types.CharacteristicsDetails other)
				{
					return true;
				}

				// Token: 0x0600172B RID: 5931 RVA: 0x002F8994 File Offset: 0x002F6B94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600172C RID: 5932 RVA: 0x002F89A4 File Offset: 0x002F6BA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600172D RID: 5933 RVA: 0x002F89B4 File Offset: 0x002F6BB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600172E RID: 5934 RVA: 0x002F89C4 File Offset: 0x002F6BC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600172F RID: 5935 RVA: 0x002F89D4 File Offset: 0x002F6BD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001730 RID: 5936 RVA: 0x002F89E4 File Offset: 0x002F6BE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacteristicsInfo.Types.CharacteristicsDetails other)
				{
				}

				// Token: 0x06001731 RID: 5937 RVA: 0x002F89F4 File Offset: 0x002F6BF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001732 RID: 5938 RVA: 0x002F8A04 File Offset: 0x002F6C04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001733 RID: 5939 RVA: 0x002F8A14 File Offset: 0x002F6C14
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CharacteristicsDetails()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							CharacteristicsInfo.Types.CharacteristicsDetails.LimitDefaultValue = 0;
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 5;
							continue;
						case 5:
							CharacteristicsInfo.Types.CharacteristicsDetails._parser = new MessageParser<CharacteristicsInfo.Types.CharacteristicsDetails>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06001734 RID: 5940 RVA: 0x002F8B0C File Offset: 0x002F6D0C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool t33QnEGpCBjoTYrtksQt()
				{
					return true;
				}

				// Token: 0x06001735 RID: 5941 RVA: 0x002F8B14 File Offset: 0x002F6D14
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacteristicsInfo.Types.CharacteristicsDetails UOO183GpDdrvh8yjKVmT()
				{
					return null;
				}

				// Token: 0x04000837 RID: 2103
				private static readonly MessageParser<CharacteristicsInfo.Types.CharacteristicsDetails> _parser;

				// Token: 0x04000838 RID: 2104
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000839 RID: 2105
				private int _hasBits0;

				// Token: 0x0400083A RID: 2106
				public const int FromBaseFieldNumber = 2;

				// Token: 0x0400083B RID: 2107
				private int fromBase_;

				// Token: 0x0400083C RID: 2108
				public const int FromAllocatedFieldNumber = 3;

				// Token: 0x0400083D RID: 2109
				private int fromAllocated_;

				// Token: 0x0400083E RID: 2110
				public const int FromEquipmentFieldNumber = 4;

				// Token: 0x0400083F RID: 2111
				private int fromEquipment_;

				// Token: 0x04000840 RID: 2112
				public const int FromBonusFieldNumber = 5;

				// Token: 0x04000841 RID: 2113
				private int fromBonus_;

				// Token: 0x04000842 RID: 2114
				public const int FromInitialBonusFieldNumber = 6;

				// Token: 0x04000843 RID: 2115
				private int fromInitialBonus_;

				// Token: 0x04000844 RID: 2116
				public const int LimitFieldNumber = 1;

				// Token: 0x04000845 RID: 2117
				private static readonly int LimitDefaultValue;

				// Token: 0x04000846 RID: 2118
				private int limit_;

				// Token: 0x04000847 RID: 2119
				internal static CharacteristicsInfo.Types.CharacteristicsDetails PlFgEBGp0MXME21Tmvh8;
			}
		}
	}
}
