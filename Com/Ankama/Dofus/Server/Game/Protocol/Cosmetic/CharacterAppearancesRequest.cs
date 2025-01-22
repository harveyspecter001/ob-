using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C5F RID: 3167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterAppearancesRequest : IMessage<CharacterAppearancesRequest>, IMessage, IEquatable<CharacterAppearancesRequest>, IDeepCloneable<CharacterAppearancesRequest>, IBufferMessage
	{
		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06009817 RID: 38935 RVA: 0x0027A81C File Offset: 0x00278A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterAppearancesRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06009818 RID: 38936 RVA: 0x0027A82C File Offset: 0x00278A2C
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

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06009819 RID: 38937 RVA: 0x0027A83C File Offset: 0x00278A3C
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

		// Token: 0x0600981A RID: 38938 RVA: 0x0027A84C File Offset: 0x00278A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesRequest()
		{
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0027A85C File Offset: 0x00278A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesRequest(CharacterAppearancesRequest other)
		{
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x0027A86C File Offset: 0x00278A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesRequest Clone()
		{
			return null;
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0027A87C File Offset: 0x00278A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x0027A88C File Offset: 0x00278A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterAppearancesRequest other)
		{
			return true;
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x0027A89C File Offset: 0x00278A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x0027A8AC File Offset: 0x00278AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x0027A8BC File Offset: 0x00278ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x0027A8CC File Offset: 0x00278ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x0027A8DC File Offset: 0x00278ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x0027A8EC File Offset: 0x00278AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterAppearancesRequest other)
		{
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x0027A8FC File Offset: 0x00278AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x0027A90C File Offset: 0x00278B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x0027A91C File Offset: 0x00278B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterAppearancesRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 2:
					CharacterAppearancesRequest._parser = new MessageParser<CharacterAppearancesRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x0027A9E8 File Offset: 0x00278BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ekttIJJNk7plrJwBumtV()
		{
			return true;
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x0027A9F0 File Offset: 0x00278BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterAppearancesRequest PPfmZ7JNlk0s1UO760Ap()
		{
			return null;
		}

		// Token: 0x04003875 RID: 14453
		private static readonly MessageParser<CharacterAppearancesRequest> _parser;

		// Token: 0x04003876 RID: 14454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003877 RID: 14455
		private static CharacterAppearancesRequest q7RfUmJNI9UAZtYE782J;
	}
}
