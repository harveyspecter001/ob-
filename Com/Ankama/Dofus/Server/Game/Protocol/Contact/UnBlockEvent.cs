using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000876 RID: 2166
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnBlockEvent : IMessage<UnBlockEvent>, IMessage, IEquatable<UnBlockEvent>, IDeepCloneable<UnBlockEvent>, IBufferMessage
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x0022E62C File Offset: 0x0022C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnBlockEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x0022E63C File Offset: 0x0022C83C
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x0022E64C File Offset: 0x0022C84C
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

		// Token: 0x06006927 RID: 26919 RVA: 0x0022E65C File Offset: 0x0022C85C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockEvent()
		{
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x0022E66C File Offset: 0x0022C86C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockEvent(UnBlockEvent other)
		{
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x0022E67C File Offset: 0x0022C87C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnBlockEvent Clone()
		{
			return null;
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x0022E68C File Offset: 0x0022C88C
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x0022E69C File Offset: 0x0022C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnBlockEvent.Types.Error Error
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

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x0022E6AC File Offset: 0x0022C8AC
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x0022E6BC File Offset: 0x0022C8BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UnBlockEvent.Types.Success Success
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

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x0022E6CC File Offset: 0x0022C8CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UnBlockEvent.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (UnBlockEvent.ResultOneofCase)null;
			}
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x0022E6E0 File Offset: 0x0022C8E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x0022E6F0 File Offset: 0x0022C8F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x0022E700 File Offset: 0x0022C900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UnBlockEvent other)
		{
			return true;
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x0022E710 File Offset: 0x0022C910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x0022E720 File Offset: 0x0022C920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x0022E730 File Offset: 0x0022C930
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x0022E740 File Offset: 0x0022C940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x0022E750 File Offset: 0x0022C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x0022E760 File Offset: 0x0022C960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UnBlockEvent other)
		{
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x0022E770 File Offset: 0x0022C970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x0022E780 File Offset: 0x0022C980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0022E790 File Offset: 0x0022C990
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UnBlockEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UnBlockEvent._parser = new MessageParser<UnBlockEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x0022E874 File Offset: 0x0022CA74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E7v1OKJnt7ARXnQPO1A8()
		{
			return true;
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x0022E87C File Offset: 0x0022CA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UnBlockEvent vXDQ9DJnwexmvgaBkfU5()
		{
			return null;
		}

		// Token: 0x040024C0 RID: 9408
		private static readonly MessageParser<UnBlockEvent> _parser;

		// Token: 0x040024C1 RID: 9409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024C2 RID: 9410
		public const int ErrorFieldNumber = 1;

		// Token: 0x040024C3 RID: 9411
		public const int SuccessFieldNumber = 2;

		// Token: 0x040024C4 RID: 9412
		private object result_;

		// Token: 0x040024C5 RID: 9413
		private UnBlockEvent.ResultOneofCase resultCase_;

		// Token: 0x040024C6 RID: 9414
		private static UnBlockEvent EZtiQrJnDNTUEZqr1Lb6;

		// Token: 0x02000877 RID: 2167
		public enum ResultOneofCase
		{
			// Token: 0x040024C8 RID: 9416
			None,
			// Token: 0x040024C9 RID: 9417
			Error,
			// Token: 0x040024CA RID: 9418
			Success
		}

		// Token: 0x02000878 RID: 2168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600693D RID: 26941 RVA: 0x002D7248 File Offset: 0x002D5448
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000879 RID: 2169
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<UnBlockEvent.Types.Error>, IMessage, IEquatable<UnBlockEvent.Types.Error>, IDeepCloneable<UnBlockEvent.Types.Error>, IBufferMessage
			{
				// Token: 0x170012F6 RID: 4854
				// (get) Token: 0x0600693E RID: 26942 RVA: 0x00306094 File Offset: 0x00304294
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<UnBlockEvent.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012F7 RID: 4855
				// (get) Token: 0x0600693F RID: 26943 RVA: 0x003060A4 File Offset: 0x003042A4
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

				// Token: 0x170012F8 RID: 4856
				// (get) Token: 0x06006940 RID: 26944 RVA: 0x003060B4 File Offset: 0x003042B4
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

				// Token: 0x06006941 RID: 26945 RVA: 0x003060C4 File Offset: 0x003042C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x06006942 RID: 26946 RVA: 0x003060D4 File Offset: 0x003042D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(UnBlockEvent.Types.Error other)
				{
				}

				// Token: 0x06006943 RID: 26947 RVA: 0x003060E4 File Offset: 0x003042E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnBlockEvent.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x06006944 RID: 26948 RVA: 0x003060F4 File Offset: 0x003042F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006945 RID: 26949 RVA: 0x00306104 File Offset: 0x00304304
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(UnBlockEvent.Types.Error other)
				{
					return true;
				}

				// Token: 0x06006946 RID: 26950 RVA: 0x00306114 File Offset: 0x00304314
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006947 RID: 26951 RVA: 0x00306124 File Offset: 0x00304324
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006948 RID: 26952 RVA: 0x00306134 File Offset: 0x00304334
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006949 RID: 26953 RVA: 0x00306144 File Offset: 0x00304344
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600694A RID: 26954 RVA: 0x00306154 File Offset: 0x00304354
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600694B RID: 26955 RVA: 0x00306164 File Offset: 0x00304364
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(UnBlockEvent.Types.Error other)
				{
				}

				// Token: 0x0600694C RID: 26956 RVA: 0x00306174 File Offset: 0x00304374
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600694D RID: 26957 RVA: 0x00306184 File Offset: 0x00304384
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600694E RID: 26958 RVA: 0x00306194 File Offset: 0x00304394
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							UnBlockEvent.Types.Error._parser = new MessageParser<UnBlockEvent.Types.Error>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x0600694F RID: 26959 RVA: 0x00306278 File Offset: 0x00304478
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool pb9YniGMAaERilLI024b()
				{
					return true;
				}

				// Token: 0x06006950 RID: 26960 RVA: 0x00306280 File Offset: 0x00304480
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static UnBlockEvent.Types.Error zAvZ1PGMBpXSqDuESjvu()
				{
					return null;
				}

				// Token: 0x040024CB RID: 9419
				private static readonly MessageParser<UnBlockEvent.Types.Error> _parser;

				// Token: 0x040024CC RID: 9420
				private UnknownFieldSet _unknownFields;

				// Token: 0x040024CD RID: 9421
				private static UnBlockEvent.Types.Error GjU60UGMmbaIUbcDJHjd;
			}

			// Token: 0x0200087B RID: 2171
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<UnBlockEvent.Types.Success>, IMessage, IEquatable<UnBlockEvent.Types.Success>, IDeepCloneable<UnBlockEvent.Types.Success>, IBufferMessage
			{
				// Token: 0x170012F9 RID: 4857
				// (get) Token: 0x06006956 RID: 26966 RVA: 0x00306288 File Offset: 0x00304488
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<UnBlockEvent.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170012FA RID: 4858
				// (get) Token: 0x06006957 RID: 26967 RVA: 0x00306298 File Offset: 0x00304498
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

				// Token: 0x170012FB RID: 4859
				// (get) Token: 0x06006958 RID: 26968 RVA: 0x003062A8 File Offset: 0x003044A8
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

				// Token: 0x06006959 RID: 26969 RVA: 0x003062B8 File Offset: 0x003044B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600695A RID: 26970 RVA: 0x003062C8 File Offset: 0x003044C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(UnBlockEvent.Types.Success other)
				{
				}

				// Token: 0x0600695B RID: 26971 RVA: 0x003062D8 File Offset: 0x003044D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnBlockEvent.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x170012FC RID: 4860
				// (get) Token: 0x0600695C RID: 26972 RVA: 0x003062E8 File Offset: 0x003044E8
				// (set) Token: 0x0600695D RID: 26973 RVA: 0x003062F8 File Offset: 0x003044F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public AccountTag Tag
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

				// Token: 0x0600695E RID: 26974 RVA: 0x00306308 File Offset: 0x00304508
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600695F RID: 26975 RVA: 0x00306318 File Offset: 0x00304518
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(UnBlockEvent.Types.Success other)
				{
					return true;
				}

				// Token: 0x06006960 RID: 26976 RVA: 0x00306328 File Offset: 0x00304528
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006961 RID: 26977 RVA: 0x00306338 File Offset: 0x00304538
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006962 RID: 26978 RVA: 0x00306348 File Offset: 0x00304548
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006963 RID: 26979 RVA: 0x00306358 File Offset: 0x00304558
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006964 RID: 26980 RVA: 0x00306368 File Offset: 0x00304568
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006965 RID: 26981 RVA: 0x00306378 File Offset: 0x00304578
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(UnBlockEvent.Types.Success other)
				{
				}

				// Token: 0x06006966 RID: 26982 RVA: 0x00306388 File Offset: 0x00304588
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006967 RID: 26983 RVA: 0x00306398 File Offset: 0x00304598
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006968 RID: 26984 RVA: 0x003063A8 File Offset: 0x003045A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_36;
							case 2:
								return;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 3;
								continue;
							}
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
							{
								num2 = 1;
							}
						}
						IL_36:
						UnBlockEvent.Types.Success._parser = new MessageParser<UnBlockEvent.Types.Success>(() => null);
						num = 2;
					}
				}

				// Token: 0x06006969 RID: 26985 RVA: 0x00306478 File Offset: 0x00304678
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool B9w8bgGM3PtKgn6ZPEfD()
				{
					return true;
				}

				// Token: 0x0600696A RID: 26986 RVA: 0x00306480 File Offset: 0x00304680
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static UnBlockEvent.Types.Success qXrIv5GMRwR8SR0T0JQD()
				{
					return null;
				}

				// Token: 0x040024D0 RID: 9424
				private static readonly MessageParser<UnBlockEvent.Types.Success> _parser;

				// Token: 0x040024D1 RID: 9425
				private UnknownFieldSet _unknownFields;

				// Token: 0x040024D2 RID: 9426
				public const int TagFieldNumber = 1;

				// Token: 0x040024D3 RID: 9427
				private AccountTag tag_;

				// Token: 0x040024D4 RID: 9428
				internal static UnBlockEvent.Types.Success zIaeKhGMeuSuFKvgFJc8;
			}
		}
	}
}
