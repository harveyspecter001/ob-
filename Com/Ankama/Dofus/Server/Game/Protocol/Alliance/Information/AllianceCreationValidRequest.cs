using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D4B RID: 3403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceCreationValidRequest : IMessage<AllianceCreationValidRequest>, IMessage, IEquatable<AllianceCreationValidRequest>, IDeepCloneable<AllianceCreationValidRequest>, IBufferMessage
	{
		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x0028E978 File Offset: 0x0028CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceCreationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x0028E988 File Offset: 0x0028CB88
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

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x0028E998 File Offset: 0x0028CB98
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

		// Token: 0x0600A3EA RID: 41962 RVA: 0x0028E9A8 File Offset: 0x0028CBA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationValidRequest()
		{
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x0028E9B8 File Offset: 0x0028CBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationValidRequest(AllianceCreationValidRequest other)
		{
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x0028E9C8 File Offset: 0x0028CBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceCreationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x0028E9D8 File Offset: 0x0028CBD8
		// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x0028E9E8 File Offset: 0x0028CBE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceName
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

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x0028E9F8 File Offset: 0x0028CBF8
		// (set) Token: 0x0600A3F0 RID: 41968 RVA: 0x0028EA08 File Offset: 0x0028CC08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceTag
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

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x0028EA18 File Offset: 0x0028CC18
		// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x0028EA28 File Offset: 0x0028CC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEmblem AllianceEmblem
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

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x0028EA38 File Offset: 0x0028CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x0028EA48 File Offset: 0x0028CC48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceCreationValidRequest other)
		{
			return true;
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x0028EA58 File Offset: 0x0028CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x0028EA68 File Offset: 0x0028CC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0028EA78 File Offset: 0x0028CC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x0028EA88 File Offset: 0x0028CC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x0028EA98 File Offset: 0x0028CC98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x0028EAA8 File Offset: 0x0028CCA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceCreationValidRequest other)
		{
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x0028EAB8 File Offset: 0x0028CCB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x0028EAC8 File Offset: 0x0028CCC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x0028EAD8 File Offset: 0x0028CCD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceCreationValidRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AllianceCreationValidRequest._parser = new MessageParser<AllianceCreationValidRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x0028EBBC File Offset: 0x0028CDBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mDFQZLJIwe2ZGWj3DcrX()
		{
			return true;
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x0028EBC4 File Offset: 0x0028CDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceCreationValidRequest I10ZnUJIQXe6u7HplvZW()
		{
			return null;
		}

		// Token: 0x04003C69 RID: 15465
		private static readonly MessageParser<AllianceCreationValidRequest> _parser;

		// Token: 0x04003C6A RID: 15466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C6B RID: 15467
		public const int AllianceNameFieldNumber = 1;

		// Token: 0x04003C6C RID: 15468
		private string allianceName_;

		// Token: 0x04003C6D RID: 15469
		public const int AllianceTagFieldNumber = 2;

		// Token: 0x04003C6E RID: 15470
		private string allianceTag_;

		// Token: 0x04003C6F RID: 15471
		public const int AllianceEmblemFieldNumber = 3;

		// Token: 0x04003C70 RID: 15472
		private SocialEmblem allianceEmblem_;

		// Token: 0x04003C71 RID: 15473
		internal static AllianceCreationValidRequest I9uE2JJIteC8kcO1JyeL;
	}
}
