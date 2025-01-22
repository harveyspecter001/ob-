using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A5F RID: 2655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterStatus : IMessage<CharacterStatus>, IMessage, IEquatable<CharacterStatus>, IDeepCloneable<CharacterStatus>, IBufferMessage
	{
		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06007EBA RID: 32442 RVA: 0x0025E4C8 File Offset: 0x0025C6C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterStatus> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x0025E4D8 File Offset: 0x0025C6D8
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

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x0025E4E8 File Offset: 0x0025C6E8
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

		// Token: 0x06007EBD RID: 32445 RVA: 0x0025E4F8 File Offset: 0x0025C6F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterStatus()
		{
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x0025E508 File Offset: 0x0025C708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterStatus(CharacterStatus other)
		{
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x0025E518 File Offset: 0x0025C718
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterStatus Clone()
		{
			return null;
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x0025E528 File Offset: 0x0025C728
		// (set) Token: 0x06007EC1 RID: 32449 RVA: 0x0025E53C File Offset: 0x0025C73C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterStatus.Types.Status Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterStatus.Types.Status)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06007EC2 RID: 32450 RVA: 0x0025E54C File Offset: 0x0025C74C
		// (set) Token: 0x06007EC3 RID: 32451 RVA: 0x0025E55C File Offset: 0x0025C75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Message
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

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x0025E56C File Offset: 0x0025C76C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x0025E57C File Offset: 0x0025C77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearMessage()
		{
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x0025E58C File Offset: 0x0025C78C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x0025E59C File Offset: 0x0025C79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterStatus other)
		{
			return true;
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x0025E5AC File Offset: 0x0025C7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x0025E5BC File Offset: 0x0025C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x0025E5CC File Offset: 0x0025C7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x0025E5DC File Offset: 0x0025C7DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x0025E5EC File Offset: 0x0025C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x0025E5FC File Offset: 0x0025C7FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterStatus other)
		{
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x0025E60C File Offset: 0x0025C80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007ECF RID: 32463 RVA: 0x0025E61C File Offset: 0x0025C81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x0025E62C File Offset: 0x0025C82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterStatus()
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
					default:
						goto IL_39;
					case 1:
						CharacterStatus.MessageDefaultValue = "";
						num2 = 3;
						break;
					case 2:
						CharacterStatus._parser = new MessageParser<CharacterStatus>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
						{
							num2 = 4;
						}
						break;
					}
				}
				IL_39:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x0025E72C File Offset: 0x0025C92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yepu9MJGH155RaAlL2qE()
		{
			return true;
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x0025E734 File Offset: 0x0025C934
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterStatus b1HuMRJGYbP31MMf99bf()
		{
			return null;
		}

		// Token: 0x04002DD7 RID: 11735
		private static readonly MessageParser<CharacterStatus> _parser;

		// Token: 0x04002DD8 RID: 11736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD9 RID: 11737
		public const int StatusFieldNumber = 1;

		// Token: 0x04002DDA RID: 11738
		private CharacterStatus.Types.Status status_;

		// Token: 0x04002DDB RID: 11739
		public const int MessageFieldNumber = 2;

		// Token: 0x04002DDC RID: 11740
		private static readonly string MessageDefaultValue;

		// Token: 0x04002DDD RID: 11741
		private string message_;

		// Token: 0x04002DDE RID: 11742
		internal static CharacterStatus H2VYaZJGp8wYsZLK62Ks;

		// Token: 0x02000A60 RID: 2656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007ED3 RID: 32467 RVA: 0x002DFCE0 File Offset: 0x002DDEE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A61 RID: 2657
			public enum Status
			{
				// Token: 0x04002DE0 RID: 11744
				[OriginalName("STATUS_OFFLINE")]
				Offline,
				// Token: 0x04002DE1 RID: 11745
				[OriginalName("STATUS_AVAILABLE")]
				Available,
				// Token: 0x04002DE2 RID: 11746
				[OriginalName("STATUS_IDLE")]
				Idle,
				// Token: 0x04002DE3 RID: 11747
				[OriginalName("STATUS_AFK")]
				Afk,
				// Token: 0x04002DE4 RID: 11748
				[OriginalName("STATUS_PRIVATE")]
				Private,
				// Token: 0x04002DE5 RID: 11749
				[OriginalName("STATUS_SOLO")]
				Solo,
				// Token: 0x04002DE6 RID: 11750
				[OriginalName("STATUS_UNKNOWN")]
				Unknown
			}
		}
	}
}
