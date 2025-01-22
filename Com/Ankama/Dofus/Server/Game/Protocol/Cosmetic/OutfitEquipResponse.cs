using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CD1 RID: 3281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipResponse : IMessage<OutfitEquipResponse>, IMessage, IEquatable<OutfitEquipResponse>, IDeepCloneable<OutfitEquipResponse>, IBufferMessage
	{
		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x0028335C File Offset: 0x0028155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x0028336C File Offset: 0x0028156C
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

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x0028337C File Offset: 0x0028157C
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

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0028338C File Offset: 0x0028158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipResponse()
		{
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0028339C File Offset: 0x0028159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipResponse(OutfitEquipResponse other)
		{
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x002833AC File Offset: 0x002815AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06009DDA RID: 40410 RVA: 0x002833BC File Offset: 0x002815BC
		// (set) Token: 0x06009DDB RID: 40411 RVA: 0x002833CC File Offset: 0x002815CC
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

		// Token: 0x06009DDC RID: 40412 RVA: 0x002833DC File Offset: 0x002815DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x002833EC File Offset: 0x002815EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipResponse other)
		{
			return true;
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x002833FC File Offset: 0x002815FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x0028340C File Offset: 0x0028160C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0028341C File Offset: 0x0028161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x0028342C File Offset: 0x0028162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x0028343C File Offset: 0x0028163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x0028344C File Offset: 0x0028164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipResponse other)
		{
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x0028345C File Offset: 0x0028165C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x0028346C File Offset: 0x0028166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x0028347C File Offset: 0x0028167C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					OutfitEquipResponse._parser = new MessageParser<OutfitEquipResponse>(() => null);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x00283560 File Offset: 0x00281760
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vZIIAeJ4P7B8owJRuhHQ()
		{
			return true;
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x00283568 File Offset: 0x00281768
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipResponse mwxGxiJ4Sh55AkruFTud()
		{
			return null;
		}

		// Token: 0x04003A74 RID: 14964
		private static readonly MessageParser<OutfitEquipResponse> _parser;

		// Token: 0x04003A75 RID: 14965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A76 RID: 14966
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A77 RID: 14967
		private bool success_;

		// Token: 0x04003A78 RID: 14968
		private static OutfitEquipResponse btlF8gJ4ivax9g7EodmT;
	}
}
