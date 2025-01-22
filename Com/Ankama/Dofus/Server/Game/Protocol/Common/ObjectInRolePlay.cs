using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B66 RID: 2918
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectInRolePlay : IMessage<ObjectInRolePlay>, IMessage, IEquatable<ObjectInRolePlay>, IDeepCloneable<ObjectInRolePlay>, IBufferMessage
	{
		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x00269328 File Offset: 0x00267528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectInRolePlay> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x00269338 File Offset: 0x00267538
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

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x00269348 File Offset: 0x00267548
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

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00269358 File Offset: 0x00267558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectInRolePlay()
		{
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x00269368 File Offset: 0x00267568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectInRolePlay(ObjectInRolePlay other)
		{
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00269378 File Offset: 0x00267578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectInRolePlay Clone()
		{
			return null;
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x00269388 File Offset: 0x00267588
		// (set) Token: 0x06008BFD RID: 35837 RVA: 0x00269398 File Offset: 0x00267598
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

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x002693A8 File Offset: 0x002675A8
		// (set) Token: 0x06008BFF RID: 35839 RVA: 0x002693B8 File Offset: 0x002675B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectGid
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

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06008C00 RID: 35840 RVA: 0x002693C8 File Offset: 0x002675C8
		// (set) Token: 0x06008C01 RID: 35841 RVA: 0x002693D8 File Offset: 0x002675D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectInRolePlay.Types.WithLook WithLook
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

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06008C02 RID: 35842 RVA: 0x002693E8 File Offset: 0x002675E8
		// (set) Token: 0x06008C03 RID: 35843 RVA: 0x002693F8 File Offset: 0x002675F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectInRolePlay.Types.PaddockItem PaddockItem
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

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008C04 RID: 35844 RVA: 0x00269408 File Offset: 0x00267608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectInRolePlay.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectInRolePlay.ComplementOneofCase)null;
			}
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x0026941C File Offset: 0x0026761C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x0026942C File Offset: 0x0026762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x0026943C File Offset: 0x0026763C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectInRolePlay other)
		{
			return true;
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x0026944C File Offset: 0x0026764C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x0026945C File Offset: 0x0026765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x0026946C File Offset: 0x0026766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x0026947C File Offset: 0x0026767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x0026948C File Offset: 0x0026768C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x0026949C File Offset: 0x0026769C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectInRolePlay other)
		{
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x002694AC File Offset: 0x002676AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x002694BC File Offset: 0x002676BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x002694CC File Offset: 0x002676CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectInRolePlay()
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
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						goto IL_88;
					case 4:
						return;
					}
				}
				IL_88:
				ObjectInRolePlay._parser = new MessageParser<ObjectInRolePlay>(() => null);
				num = 4;
			}
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x002695B4 File Offset: 0x002677B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JMDq6IJ9eAluGwol36Ro()
		{
			return true;
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x002695BC File Offset: 0x002677BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectInRolePlay LD1Jh6J93cfBBHwvtjHn()
		{
			return null;
		}

		// Token: 0x040033B1 RID: 13233
		private static readonly MessageParser<ObjectInRolePlay> _parser;

		// Token: 0x040033B2 RID: 13234
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033B3 RID: 13235
		public const int CellIdFieldNumber = 1;

		// Token: 0x040033B4 RID: 13236
		private int cellId_;

		// Token: 0x040033B5 RID: 13237
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x040033B6 RID: 13238
		private int objectGid_;

		// Token: 0x040033B7 RID: 13239
		public const int WithLookFieldNumber = 3;

		// Token: 0x040033B8 RID: 13240
		public const int PaddockItemFieldNumber = 4;

		// Token: 0x040033B9 RID: 13241
		private object complement_;

		// Token: 0x040033BA RID: 13242
		private ObjectInRolePlay.ComplementOneofCase complementCase_;

		// Token: 0x040033BB RID: 13243
		internal static ObjectInRolePlay VPWlMIJ9Bxs5QfCN8acv;

		// Token: 0x02000B67 RID: 2919
		public enum ComplementOneofCase
		{
			// Token: 0x040033BD RID: 13245
			None,
			// Token: 0x040033BE RID: 13246
			WithLook = 3,
			// Token: 0x040033BF RID: 13247
			PaddockItem
		}

		// Token: 0x02000B68 RID: 2920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008C13 RID: 35859 RVA: 0x002E3FE8 File Offset: 0x002E21E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B69 RID: 2921
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class WithLook : IMessage<ObjectInRolePlay.Types.WithLook>, IMessage, IEquatable<ObjectInRolePlay.Types.WithLook>, IDeepCloneable<ObjectInRolePlay.Types.WithLook>, IBufferMessage
			{
				// Token: 0x17001A01 RID: 6657
				// (get) Token: 0x06008C14 RID: 35860 RVA: 0x0030C2F8 File Offset: 0x0030A4F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectInRolePlay.Types.WithLook> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A02 RID: 6658
				// (get) Token: 0x06008C15 RID: 35861 RVA: 0x0030C308 File Offset: 0x0030A508
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

				// Token: 0x17001A03 RID: 6659
				// (get) Token: 0x06008C16 RID: 35862 RVA: 0x0030C318 File Offset: 0x0030A518
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

				// Token: 0x06008C17 RID: 35863 RVA: 0x0030C328 File Offset: 0x0030A528
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public WithLook()
				{
				}

				// Token: 0x06008C18 RID: 35864 RVA: 0x0030C338 File Offset: 0x0030A538
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public WithLook(ObjectInRolePlay.Types.WithLook other)
				{
				}

				// Token: 0x06008C19 RID: 35865 RVA: 0x0030C348 File Offset: 0x0030A548
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectInRolePlay.Types.WithLook Clone()
				{
					return null;
				}

				// Token: 0x17001A04 RID: 6660
				// (get) Token: 0x06008C1A RID: 35866 RVA: 0x0030C358 File Offset: 0x0030A558
				// (set) Token: 0x06008C1B RID: 35867 RVA: 0x0030C368 File Offset: 0x0030A568
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public EntityLook Look
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

				// Token: 0x17001A05 RID: 6661
				// (get) Token: 0x06008C1C RID: 35868 RVA: 0x0030C378 File Offset: 0x0030A578
				// (set) Token: 0x06008C1D RID: 35869 RVA: 0x0030C38C File Offset: 0x0030A58C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Direction Direction
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (Direction)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17001A06 RID: 6662
				// (get) Token: 0x06008C1E RID: 35870 RVA: 0x0030C39C File Offset: 0x0030A59C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasDirection
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06008C1F RID: 35871 RVA: 0x0030C3AC File Offset: 0x0030A5AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearDirection()
				{
				}

				// Token: 0x06008C20 RID: 35872 RVA: 0x0030C3BC File Offset: 0x0030A5BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008C21 RID: 35873 RVA: 0x0030C3CC File Offset: 0x0030A5CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectInRolePlay.Types.WithLook other)
				{
					return true;
				}

				// Token: 0x06008C22 RID: 35874 RVA: 0x0030C3DC File Offset: 0x0030A5DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008C23 RID: 35875 RVA: 0x0030C3EC File Offset: 0x0030A5EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008C24 RID: 35876 RVA: 0x0030C3FC File Offset: 0x0030A5FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008C25 RID: 35877 RVA: 0x0030C40C File Offset: 0x0030A60C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008C26 RID: 35878 RVA: 0x0030C41C File Offset: 0x0030A61C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008C27 RID: 35879 RVA: 0x0030C42C File Offset: 0x0030A62C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectInRolePlay.Types.WithLook other)
				{
				}

				// Token: 0x06008C28 RID: 35880 RVA: 0x0030C43C File Offset: 0x0030A63C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008C29 RID: 35881 RVA: 0x0030C44C File Offset: 0x0030A64C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008C2A RID: 35882 RVA: 0x0030C45C File Offset: 0x0030A65C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static WithLook()
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
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						case 5:
							ObjectInRolePlay.Types.WithLook.DirectionDefaultValue = Direction.East;
							num2 = 4;
							continue;
						}
						ObjectInRolePlay.Types.WithLook._parser = new MessageParser<ObjectInRolePlay.Types.WithLook>(() => null);
						num2 = 5;
					}
				}

				// Token: 0x06008C2B RID: 35883 RVA: 0x0030C554 File Offset: 0x0030A754
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool tclOApG8PLx2QccUGNa8()
				{
					return true;
				}

				// Token: 0x06008C2C RID: 35884 RVA: 0x0030C55C File Offset: 0x0030A75C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectInRolePlay.Types.WithLook LWZ4mbG8S4eU9OtwyQs6()
				{
					return null;
				}

				// Token: 0x040033C0 RID: 13248
				private static readonly MessageParser<ObjectInRolePlay.Types.WithLook> _parser;

				// Token: 0x040033C1 RID: 13249
				private UnknownFieldSet _unknownFields;

				// Token: 0x040033C2 RID: 13250
				private int _hasBits0;

				// Token: 0x040033C3 RID: 13251
				public const int LookFieldNumber = 1;

				// Token: 0x040033C4 RID: 13252
				private EntityLook look_;

				// Token: 0x040033C5 RID: 13253
				public const int DirectionFieldNumber = 2;

				// Token: 0x040033C6 RID: 13254
				private static readonly Direction DirectionDefaultValue;

				// Token: 0x040033C7 RID: 13255
				private Direction direction_;

				// Token: 0x040033C8 RID: 13256
				internal static ObjectInRolePlay.Types.WithLook e3DZI6G8iKxXa9mbpPTy;
			}

			// Token: 0x02000B6B RID: 2923
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PaddockItem : IMessage<ObjectInRolePlay.Types.PaddockItem>, IMessage, IEquatable<ObjectInRolePlay.Types.PaddockItem>, IDeepCloneable<ObjectInRolePlay.Types.PaddockItem>, IBufferMessage
			{
				// Token: 0x17001A07 RID: 6663
				// (get) Token: 0x06008C32 RID: 35890 RVA: 0x0030C564 File Offset: 0x0030A764
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ObjectInRolePlay.Types.PaddockItem> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A08 RID: 6664
				// (get) Token: 0x06008C33 RID: 35891 RVA: 0x0030C574 File Offset: 0x0030A774
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

				// Token: 0x17001A09 RID: 6665
				// (get) Token: 0x06008C34 RID: 35892 RVA: 0x0030C584 File Offset: 0x0030A784
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

				// Token: 0x06008C35 RID: 35893 RVA: 0x0030C594 File Offset: 0x0030A794
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockItem()
				{
				}

				// Token: 0x06008C36 RID: 35894 RVA: 0x0030C5A4 File Offset: 0x0030A7A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockItem(ObjectInRolePlay.Types.PaddockItem other)
				{
				}

				// Token: 0x06008C37 RID: 35895 RVA: 0x0030C5B4 File Offset: 0x0030A7B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectInRolePlay.Types.PaddockItem Clone()
				{
					return null;
				}

				// Token: 0x17001A0A RID: 6666
				// (get) Token: 0x06008C38 RID: 35896 RVA: 0x0030C5C4 File Offset: 0x0030A7C4
				// (set) Token: 0x06008C39 RID: 35897 RVA: 0x0030C5D4 File Offset: 0x0030A7D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Durability
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

				// Token: 0x17001A0B RID: 6667
				// (get) Token: 0x06008C3A RID: 35898 RVA: 0x0030C5E4 File Offset: 0x0030A7E4
				// (set) Token: 0x06008C3B RID: 35899 RVA: 0x0030C5F4 File Offset: 0x0030A7F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int DurabilityMax
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

				// Token: 0x06008C3C RID: 35900 RVA: 0x0030C604 File Offset: 0x0030A804
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008C3D RID: 35901 RVA: 0x0030C614 File Offset: 0x0030A814
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectInRolePlay.Types.PaddockItem other)
				{
					return true;
				}

				// Token: 0x06008C3E RID: 35902 RVA: 0x0030C624 File Offset: 0x0030A824
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008C3F RID: 35903 RVA: 0x0030C634 File Offset: 0x0030A834
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008C40 RID: 35904 RVA: 0x0030C644 File Offset: 0x0030A844
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008C41 RID: 35905 RVA: 0x0030C654 File Offset: 0x0030A854
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008C42 RID: 35906 RVA: 0x0030C664 File Offset: 0x0030A864
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008C43 RID: 35907 RVA: 0x0030C674 File Offset: 0x0030A874
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectInRolePlay.Types.PaddockItem other)
				{
				}

				// Token: 0x06008C44 RID: 35908 RVA: 0x0030C684 File Offset: 0x0030A884
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008C45 RID: 35909 RVA: 0x0030C694 File Offset: 0x0030A894
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008C46 RID: 35910 RVA: 0x0030C6A4 File Offset: 0x0030A8A4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PaddockItem()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							ObjectInRolePlay.Types.PaddockItem._parser = new MessageParser<ObjectInRolePlay.Types.PaddockItem>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
							{
								num2 = 1;
							}
							break;
						}
					}
				}

				// Token: 0x06008C47 RID: 35911 RVA: 0x0030C788 File Offset: 0x0030A988
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool JOF1RIG8uZx4jnodxUrI()
				{
					return true;
				}

				// Token: 0x06008C48 RID: 35912 RVA: 0x0030C790 File Offset: 0x0030A990
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectInRolePlay.Types.PaddockItem txvHrtG88Aq5sChOq3tS()
				{
					return null;
				}

				// Token: 0x040033CB RID: 13259
				private static readonly MessageParser<ObjectInRolePlay.Types.PaddockItem> _parser;

				// Token: 0x040033CC RID: 13260
				private UnknownFieldSet _unknownFields;

				// Token: 0x040033CD RID: 13261
				public const int DurabilityFieldNumber = 1;

				// Token: 0x040033CE RID: 13262
				private int durability_;

				// Token: 0x040033CF RID: 13263
				public const int DurabilityMaxFieldNumber = 2;

				// Token: 0x040033D0 RID: 13264
				private int durabilityMax_;

				// Token: 0x040033D1 RID: 13265
				private static ObjectInRolePlay.Types.PaddockItem eKSaUhG8Mo0qmTqjcgTR;
			}
		}
	}
}
